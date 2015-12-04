using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public abstract class Schedule
    {
        public TimeSpan timeOfDay { get; set; }
        public string name { get; set; }
        
        public abstract bool OccursOnDate(DateTime date);
    }
}
