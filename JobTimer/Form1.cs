using System.Text.Json;

namespace JobTimer
{
    public partial class Form1 : Form
    {

        private readonly MyJobTimer _jobTimer;

        public Form1()
        {
            InitializeComponent();

            _jobTimer = new MyJobTimer(timerWork, timerRest, timeWorkLabel, timeRestLabel, DayResultWorkLabel, DayResultRestLabel, timeWorkRecordLabel);
        }

        private void StartWorkButton_Click(object sender, EventArgs e)
        {
            _jobTimer.StartWork();
        }

        private void StartRestButton_Click(object sender, EventArgs e)
        {
            _jobTimer.StartRest();
        }

        private void timerRest_Tick(object sender, EventArgs e)
        {
            _jobTimer.TimerRest_Tick();
        }

        private void timerWork_Tick(object sender, EventArgs e)
        {
            _jobTimer.TimerWork_Tick();
        }

        private void ConButton_Click(object sender, EventArgs e)
        {
            _jobTimer.ConButton_Click();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryInfo hi = new HistoryInfo();
            hi.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _jobTimer.Form1_FormClosing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _jobTimer.Form1_Load();
        }
    }
}