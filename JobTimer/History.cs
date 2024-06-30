using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JobTimer
{
    public class History
    {
        public static List<DayInfo> GetHistory()
        {
            var fileWithHistory = "history.json";

            if (File.Exists(fileWithHistory))
            {
                using (StreamReader r = new StreamReader(fileWithHistory))
                {
                    string json = r.ReadToEnd();
                    var records = JsonSerializer.Deserialize<IEnumerable<DayInfoRecord>>(json);
                    //var dates = records.Select(r=>DateTime.Parse(r.WorkDate)).OrderByDescending(q=>q.Date);
                    var orderedDayInfo = records.Select(r => 
                        new DayInfo(
                            DateTime.Parse(r.WorkDate),
                            r.WorkedTime, 
                            r.FinedTime,
                            r.WorkedTimeRecord))
                        .OrderByDescending(q => q.WorkDate.Date);

                    //var orderedInfo = new List<DayInfo>();
                    //foreach (var day in dates)
                    //{
                    //    orderedInfo.Add(records.FirstOrDefault(r => r.WorkDate == day));
                    //}

                    return orderedDayInfo.ToList();
                }
            }

            return null;
        }
    }
}
