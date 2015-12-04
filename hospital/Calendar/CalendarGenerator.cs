using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class CalendarGenerator
    {
        public IEnumerable<Appointment> GenerateCalendar(Period period, IEnumerable<Schedule> schedules)
        {
            var appointments = new List<Appointment>();
            for (DateTime checkDate = period.start; checkDate <= period.end; checkDate = checkDate.AddDays(1))
            {
                AddAppointmentsForDate(checkDate, schedules, appointments);
            }
            return appointments.OrderBy(a => a.time);
        }

        private void AddAppointmentsForDate(DateTime checkDate, IEnumerable<Schedule> schedules, List<Appointment> appointments)
        {
            foreach (Schedule schedule in schedules)
            {
                if (schedule.OccursOnDate(checkDate))
                {
                    appointments.Add(GenerateAppointment(checkDate,schedule));
                }
            }
        }

        private Appointment GenerateAppointment(DateTime checkDate, Schedule schedule)
        {
            Appointment appointment = new Appointment
            {
                name = schedule.name
               ,doctorName = schedule.doctorName
               ,time = checkDate.Add(schedule.timeOfDay)
            };
            return appointment;
        }
    }
}
