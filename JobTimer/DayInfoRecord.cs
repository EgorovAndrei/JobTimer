using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTimer
{
    public class DayInfoRecord
    {
        public DayInfoRecord(string workdate, string workedTime, string finedTime, string workedTimeRecord)
        {
            WorkDate = workdate;
            WorkedTime = workedTime;
            FinedTime = finedTime;
            WorkedTimeRecord = workedTimeRecord;
        }
        public string WorkDate { get; set; }
        public string WorkedTime { get; set; }
        public string FinedTime { get; set; }
        public string WorkedTimeRecord { get; set; }
    }
}
