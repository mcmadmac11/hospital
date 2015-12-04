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
        private Patient patient;
        private Appointment appointment;
       // private Diagnosis diagnosis;
        private string diagnosis;

        public Report(Patient patient, Appointment appointment, string diagnosis)
        {
            this.patient = patient;
            this.appointment = appointment;
            this.diagnosis = diagnosis; 
        }

        //public void ReconstructReport(Patient patient, Appointment appointment, string diagnosis) 
        //{
        //    this.patient = patient;
        //    this.appointment = appointment;
        //    this.diagnosis = diagnosis;
        //}

        public Patient OutputPatient()
        {
            return patient;
        }

        public Appointment OutputAppointment()
        {
            return appointment;
        }

        //public Diagnosis OutputDiagnosis()
        //{
        //    return diagnosis;
        //}
        public string OutputDiagnosis()
        {
            return diagnosis;
        }

        public ReportXML ConstructReportXML()
        {
            var report = new ReportXML();
            report.Initialize(this);
            return report;
        }
    }
}
