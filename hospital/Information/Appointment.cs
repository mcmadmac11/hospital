using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public class Appointment
    {
        public string time;
        public string date;
        public string patientName;
        public string doctorName;

        public Appointment() { }

        public void Initialize(string time, string date, string patientName, string doctorName)
        {
            this.time = time;
            this.date = date;
            this.patientName = patientName;
            this.doctorName = doctorName;
        }
    }
}