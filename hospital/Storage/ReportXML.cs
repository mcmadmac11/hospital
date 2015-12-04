using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;
using Information;

namespace Storage
{
    public class ReportXML
    {
        private Report report;
        public Appointment appointment;
        public string diagnosis;
        public string[][] patientInfo;

        public ReportXML() {}

        public void Initialize(Report report)
        {
            this.report = report;
            SetPatientInfo();
            SetDiagnosis();
            SetAppointmentInfo();
        }

        public Report ReconstructReport()
        {
            var r = new Reconstruction(this);
            report = r.ReconstructReport();
            return report;
        }

        private void SetPatientInfo()
        {
            var patient = report.OutputPatient();
            string[] insurance;
            try
            {
                insurance = patient.Talk("insurance").XMLOutput();
            }
            catch
            {
                insurance = new string[] { null };
            }
            Console.WriteLine(insurance);
            string[] finalInsurance = insurance;
            var patientInfo = new string[][]
            {
                new string[] { patient.Talk("name") }
               ,new string[] { patient.Talk("dob") }
               ,new string[] { patient.Talk("ssn") }
               ,finalInsurance
            };
            this.patientInfo = patientInfo;
        }

        private void SetAppointmentInfo()
        {
            this.appointment = report.OutputAppointment();
        }

        private void SetDiagnosis()
        {
            this.diagnosis = report.OutputDiagnosis();
        }

        private class Reconstruction
        {
            private ReportXML xml;
            private Patient patient;

            public Reconstruction(ReportXML xml)
            {
                this.xml = xml;
            }

            public Report ReconstructReport()
            {
                ReconstructPatient();
                var report = new Report(patient, (Appointment)xml.appointment, (string)xml.diagnosis);
                return report;
            }

            private void ReconstructPatient()
            {
                var personFactory = new PersonFactory();
                var patientInfo = xml.patientInfo;
                var insurance = ReconstructInsurance(patientInfo);
                patient = personFactory.CreatePatient(patientInfo[0][0], patientInfo[1][0], patientInfo[2][0], insurance);
            }

            private Insurance ReconstructInsurance(string[][] patientInfo)
            {
                Insurance insurance;
                try
                { 
                    insurance = new Insurance(patientInfo[3][0], patientInfo[3][1], patientInfo[3][2], patientInfo[3][3]);
                }
                catch
                {
                    insurance = null;
                }
                return insurance;
            }
        }
    }
}
