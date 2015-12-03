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
          

            var p1 = personFactory.CreatePatient("Sam", "09/02/1985");
            var d1 = personFactory.CreateDoctor("Dr. Jim", "immortal");
          
            var appointment = new Appointment("12:00", "10/5/2016", p1, "R20", d1);
            var diagnosis = "ebola";

            var report = new ReportGenerator(p1, appointment.GetAppointmentInfo(), diagnosis).report;

            Console.WriteLine(report.OutputPatient().Talk("name"));
            Console.WriteLine(report.OutputDiagnosis());

            Database controller = new Database();
            controller.AddReport(report);
            var reports = controller.reports;
            //Console.WriteLine(reports.Count());
            var rp = reports.OutputPatient();
            Console.WriteLine(reports);
            Console.WriteLine(rp);
            Console.WriteLine(rp.Talk("name"));
            var rr = controller.ViewReports();
            var rrp = rr.OutputPatient();
            Console.WriteLine(rr);
            Console.WriteLine(rrp);
            Console.WriteLine(rrp.Talk("name"));

        
        }
    }
}