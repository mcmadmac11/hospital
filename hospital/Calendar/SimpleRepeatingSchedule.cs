using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class SimpleRepeatingSchedule : RepeatingSchedule
    {
        private int daysBetween;

        public int DaysBetween
        {
            get
            {
                return daysBetween;
            }

            set
            {
                if (value <=0) throw new ArgumentException("The days between appointments must be at least one.");
                daysBetween = value;
            }
        }

        public override bool OccursOnDate(DateTime date)
        {
            if (DateIsInPeriod(date))
            {
                return DateIsValidForSchedule(date);
            }
            return false;
        }

        private bool DateIsValidForSchedule(DateTime date)
        {
            int daysBetweenFirstAndCheckDate = (int)date.Subtract(schedulingRange.start).TotalDays;
            return daysBetweenFirstAndCheckDate % DaysBetween == 0;
        }
    }
}
