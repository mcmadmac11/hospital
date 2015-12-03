using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;

namespace Storage
{
    class Calendar 
    {
        private Application outlookApp;
        public Calendar()
        {
            outlookApp = new Application();
        }

        public void AddAppointment(string name, string body, string location, string start, string end)
        {
            var appointment = (AppointmentItem)outlookApp.CreateItem(OlItemType.olAppointmentItem);
            appointment.Subject = string.Format("Doctor Appointment for {1}", name);
            appointment.Body = body;
            appointment.Location = location;
            appointment.Start = Convert.ToDateTime(start);
            appointment.End = Convert.ToDateTime(end);
            appointment.ReminderSet = true;
            appointment.ReminderMinutesBeforeStart = 180;
            appointment.Importance = OlImportance.olImportanceHigh;
            appointment.BusyStatus = OlBusyStatus.olBusy;

            appointment.Save();
        }

        private void ConfirmationEmail(AppointmentItem appointment, string email)
        {
            //check formatting, also, why not send with option to add to recipients gmail calendar?
            MailItem mailItem = appointment.ForwardAsVcal();
            mailItem.To = string.Format("mailto:{1}", email)>email;
            mailItem.Send();
        }
    }
}
