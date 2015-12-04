using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;
using Structure;
using Information;
using Storage;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No bugs!");
            WaitingRoom room = new WaitingRoom();
            var personFactory = new PersonFactory();
          

            var p1 = personFactory.CreatePatient("Liam", "09/02/1985");
            var d1 = personFactory.CreateDoctor("Dr. Fong", "immortal");
          
            var appointment = new Appointment();
            appointment.Initialize("12:00", "10/5/2016", p1.Talk("name"), d1.Talk("name"));
            var diagnosis = "ebola";

            var report = new Report(p1, appointment, diagnosis);
            Console.WriteLine(report.OutputPatient().Talk("name"));
            Console.WriteLine(report.OutputDiagnosis());

            Database controller = new Database();
            var ReportXML = report.ConstructReportXML();
            controller.AddReport(ReportXML);

            var r = controller.ViewReports();
            var newReport = r[0].ReconstructReport();

            Console.WriteLine(newReport.OutputPatient().Talk("name"));
            Console.WriteLine(report.OutputDiagnosis());



        
        }
    }
}