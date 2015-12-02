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

        public ReportGenerator(Patient patient, Dictionary<string, string> appointmentInfo, string diagnosis)//replace string diagnosis with Diagnosis diagnosis when functinal
        {
            var report = new Report();
            report.ConstructReport(this, patient, appointmentInfo, diagnosis);
            this.report = report;
        }
    }
}
