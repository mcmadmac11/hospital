using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    class Appointment
    {
        private string time;
        private string date;
        private Patient patient;
        private string roomNumber;
        private string doctor;

        public Appointment(string time, string date, Patient patient, string roomNumber, string doctor)
        {
            this.time = time;
            this.date = date;
            this.patient = patient;
            this roomNumber = roomNumber;
        }
    }
}
