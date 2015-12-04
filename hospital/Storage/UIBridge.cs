using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar;

namespace Storage
{
    public class UIBridge
    {
        private string name;
        private string doctorName;
        private DateTime date; //DateTime(2015, 12, 4)
        private TimeSpan timeOfDay; // TimeSpan(9, 20, 0)

        public UIBridge(string name, string doctorName, string date, string timeOfDay)
        {
            this.name = name;
            this.doctorName = doctorName;
            this.date = DateTime.Parse(date);
            this.timeOfDay = TimeSpan.Parse(timeOfDay);
        }
        public Schedule ScheduleSingleAppointment()
        {
            var singleSchedule = new SingleSchedule {name = this.name, doctorName = this.doctorName, timeOfDay= this.timeOfDay, date = this.date };
            return singleSchedule;
        }
    }
}
