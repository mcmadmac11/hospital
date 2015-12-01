using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public class Appointment
    {
        private string time;
        private string date;
        private IPerson patient;
        private string roomNumber;
        private IPerson doctor;

        public Appointment(string time, string date, IPerson patient, string roomNumber, IPerson doctor)
        {
            this.time = time;
            this.date = date;
            this.patient = patient;
            this.roomNumber = roomNumber;
            this.doctor = doctor;
        }
    }
}
