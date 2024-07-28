using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace JobTimer
{
    public class MyJobTimer
    {
        private const string fileWithHistory = "history.json";

        private readonly SoundPlayer soundPlayer = new SoundPlayer(@"DingDong.wav");

        private readonly TimeSpan sec = TimeSpan.FromSeconds(1);
        private readonly TimeSpan min = TimeSpan.FromMinutes(1);

        private TimeSpan _timespanForWork;
        private TimeSpan _timespanForRest;
        private TimeSpan _timespanForFine;
        private TimeSpan _timespanDayResultWork;
        private TimeSpan _timespanDayResultRest;
        private TimeSpan _timespanCurrentRecord;

        private Timer _timer_work;
        private Timer _timer_rest;
        private Label _label_timeWork;
        private Label _label_timeRest;
        private Label _label_dayResultWork;
        private Label _label_dayResultRest;
        private Label _label_timeWorkRecord;

        public MyJobTimer(
            Timer timer_work,
            Timer timer_rest,
            Label label_timeWork,
            Label label_timeRest,
            Label label_dayResultWork,
            Label label_dayResultRest,
            Label label_timeWorkRecord)
        {
            _timespanForWork = new TimeSpan();
            _timespanForRest = new TimeSpan();
            _timespanForFine = new TimeSpan();

            _label_dayResultWork = label_dayResultWork;
            _label_timeWork = label_timeWork;
            _label_timeRest = label_timeRest;
            _label_timeWorkRecord = label_timeWorkRecord;
            _label_dayResultRest = label_dayResultRest;

            _timer_work = timer_work;
            _timer_rest = timer_rest;
        }

        public void StartRest()
        {
            _timespanDayResultWork += _timespanForWork;
            _timer_work.Enabled = false;
            _timer_rest.Enabled = true;

            if (_timespanCurrentRecord < _timespanForWork)
            {
                _timespanCurrentRecord = _timespanForWork;
                UpdateLabels();
            }

            _timespanForWork = new TimeSpan(0, 0, 0);
            _label_timeWork.Text = "00:00";

            UpdateLabels();
        }

        public void StartWork()
        {
            _timespanDayResultRest += _timespanForRest;
            _label_timeRest.Text = "00:00";
            _timespanForRest = new TimeSpan(0, 0, 0);
            _timer_work.Enabled = true;
            _timer_rest.Enabled = false;
            UpdateLabels();
        }

        public void TimerRest_Tick()
        {
            _timespanForRest = _timespanForRest.Add(sec);

            DingDong(_timespanForRest);

            UpdateLabels();
        }

        public void TimerWork_Tick()
        {
            _timespanForWork = _timespanForWork.Add(sec);

            DingDong(_timespanForWork);

            UpdateLabels();
        }

        public void ConButton_Click()
        {
            _timespanForWork = _timespanForWork.Subtract(min);
            _timespanForFine = _timespanForFine.Add(min);
        }

        public void Form1_FormClosing()
        {
            var days = History.GetHistory();

            var currentDay = days.FirstOrDefault(d => d.WorkDate == DateTime.Now.Date);
            if (currentDay != null)
            {
                currentDay.WorkedTime = _timespanDayResultWork.ToString();
                currentDay.FinedTime = _timespanForFine.ToString();
                currentDay.WorkedTimeRecord = _timespanCurrentRecord.ToString();
            }
            else
            {
                days.Add(new DayInfo(DateTime.Now.Date,
                _timespanDayResultWork.ToString(),
                _timespanForFine.ToString(),
                _timespanCurrentRecord.ToString()));
            }

            var jsonString = JsonSerializer.Serialize(days);
            File.WriteAllText(fileWithHistory, jsonString);
        }

        public void Form1_Load()
        {
            var days = History.GetHistory();
            var currentDay = days.FirstOrDefault(d => d.WorkDate == DateTime.Now.Date);

            if (currentDay != null)
            {                
                _timespanDayResultWork = TimeSpan.Parse(currentDay.WorkedTime);
                _timespanCurrentRecord = TimeSpan.Parse(currentDay.WorkedTimeRecord);

                TimeSpan.TryParse(currentDay.FinedTime, out var finedTime);
                _timespanForFine = finedTime;                
                
                UpdateLabels();
            }
        }

        private void UpdateLabels()
        {
            _label_dayResultWork.Text = _timespanDayResultWork.ToString();
            _label_dayResultRest.Text = _timespanDayResultRest.ToString();
            _label_timeRest.Text = _timespanForRest.ToString(@"mm\:ss");
            _label_timeWork.Text = _timespanForWork.ToString(@"mm\:ss");
            _label_timeWorkRecord.Text = _timespanCurrentRecord.ToString(@"mm\:ss");
        }

        private void DingDong(TimeSpan timeSpanForCheck)
        {
            if (timeSpanForCheck.Minutes != 0 && timeSpanForCheck.Minutes % 5 == 0 && timeSpanForCheck.Seconds == 0)
            {
                soundPlayer.Play();
            }
        }
    }
}
