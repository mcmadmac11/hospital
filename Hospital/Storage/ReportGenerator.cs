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
        public ReportGenerator() { }

        private class Report
        {
            private Patient patient;
            private Dictionary<string, string> appointmentInfo;
            private Diagnosis diagnosis;


            public Report() { }
        }
    }
}
