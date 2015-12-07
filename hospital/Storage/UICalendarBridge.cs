using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar;

namespace Storage
{
    public class UICalendarBridge
    {
        private CalendarGenerator generator;
        private Database controller;
        private Period period;

        public UICalendarBridge()
        {
            generator = new CalendarGenerator();
            controller = new Database();
            period = new Period(new DateTime(2010, 12, 1), new DateTime(2018, 1, 1));
        }

        public void ScheduleSingleAppointment(string name, string doctorName, TimeSpan timeOfDay, DateTime date)
        {
            Schedule[] singleSchedule = new Schedule[] { new SingleSchedule { name = name, doctorName = doctorName, timeOfDay= timeOfDay, date = date } };
            var appointment = CreateAppointment(singleSchedule)[0];
            controller.schedule.Add(appointment);
            controller.UpdateDatabase();
        }

        private Appointment[] CreateAppointment(Schedule[] schedule)
        {
            var appointment = generator.GenerateCalendar(period, schedule);
            return appointment.ToArray();
        }

        public IEnumerable<Appointment> GetCalendar()
        {
            return controller.schedule;
        }
    }
}
