using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class SingleSchedule : Schedule
    {
        public DateTime date { get; set; }

        public override bool OccursOnDate(DateTime date)
        {
            return this.date == date;
        }
    }
}
