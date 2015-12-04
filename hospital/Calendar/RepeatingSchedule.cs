using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public abstract class RepeatingSchedule : Schedule
    {
        public Period schedulingRange { get; set; }
        protected bool DateIsInPeriod(DateTime date)
        {
            return date >= schedulingRange.start && date <= schedulingRange.end;
        }
    }
}
