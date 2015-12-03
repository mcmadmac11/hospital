using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;
using Information;

namespace Storage
{
    public class Report
    {
        public Patient patient;
        public Dictionary<string, string> appointmentInfo;
       // private Diagnosis diagnosis;
        public string diagnosis;

        public Report() { }

        public void ConstructReport(ReportGenerator limiter, Patient patient, Dictionary<string, string> appointmentInfo, string diagnosis) //replace string diagnosis with Diagnosis diagnosis when functional, uncomment out other code to replace the string code respectively
        {
            this.patient = patient;
            this.appointmentInfo = appointmentInfo;
            this.diagnosis = diagnosis;
        }

        public Patient OutputPatient()
        {
            return patient;
        }

        public Dictionary<string, string> OutputAppointmentInfo()
        {
            return appointmentInfo;
        }

        //public Diagnosis OutputDiagnosis()
        //{
        //    return diagnosis;
        //}
        public string OutputDiagnosis()
        {
            return diagnosis;
        }
    }
}
