using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class WeeklySchedule : RepeatingSchedule
    {
        List<DayOfWeek> days;
        public void SetDays(IEnumerable<DayOfWeek> days)
        {
            days = days.Distinct().ToList();
        }

        public override bool OccursOnDate(DateTime date)
        {
            return DateIsInPeriod(date) && days.Contains(date.DayOfWeek);
        }
    }
}
