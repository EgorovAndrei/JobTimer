using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTimer
{
    public partial class HistoryInfo : Form
    {
        public HistoryInfo()
        {
            InitializeComponent();
        }

        private void HistoryInfo_Load(object sender, EventArgs e)
        {
            var days = History.GetHistory();
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Worked time", "Worked time");
            dataGridView1.Columns.Add("Fined time", "Fined time");
            dataGridView1.Columns.Add("Record", "Record");

            foreach (var day in days)
            {
                dataGridView1.Rows.Add(day.WorkDate, day.WorkedTime, day.FinedTime, day.WorkedTimeRecord);
            }

            var maxWorkedTime = TimeSpan.Zero;
            var dayOfRecord = "";
            foreach (var day in days)
            {
                var tmpWorkedTime = TimeSpan.Zero;
                TimeSpan.TryParse(day.WorkedTime, out tmpWorkedTime);
                if (maxWorkedTime < tmpWorkedTime)
                {
                    maxWorkedTime = tmpWorkedTime;
                    dayOfRecord = day.WorkDate.ToString();
                }
            }
            labelMaxWorkedTime.Text = maxWorkedTime + " (" + dayOfRecord + ")";
        }
    }
}
