using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;
using Information;

namespace Storage
{
     public class ReportGenerator
    {
        public Report report;

        public ReportGenerator(Patient patient, Dictionary<string, string> appointmentInfo, Diagnosis diagnosis)
        {
            var report = new Report();
            report.ConstructReport(this, patient, appointmentInfo, diagnosis);
            this.report = report;
        }


        public class Report
        {
            private Patient patient;
            private Dictionary<string, string> appointmentInfo;
            private Diagnosis diagnosis;


            public Report() { }

            public void ConstructReport(ReportGenerator limiter, Patient patient, Dictionary<string, string> appointmentInfo, Diagnosis diagnosis)
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

            public Diagnosis OutputDiagnosis()
            {
                return diagnosis;
            }
        }
    }
}
