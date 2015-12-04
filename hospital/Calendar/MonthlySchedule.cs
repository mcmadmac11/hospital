using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class MonthlySchedule : RepeatingSchedule
    {
        public int dayOfMonth { get; set; }

        public override bool OccursOnDate(DateTime date)
        {
            return DateIsInPeriod(date) & IsOnCorrectDate(date);
        }

        private bool IsOnCorrectDate(DateTime date)
        {
            if (date.Day == dayOfMonth)
                return true;
            else if (date.Day == DateTime.DaysInMonth(date.Year, date.Month) && dayOfMonth > date.Day)
                return true;
            else
                return false;
        }
    }
}
