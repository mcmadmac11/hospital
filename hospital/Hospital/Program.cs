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

            Console.WriteLine(report.OutputPatient());
            Console.WriteLine(report.OutputDiagnosis());
            Console.WriteLine(report.OutputAppointmentInfo());

            Database controller = new Database();

            var reports = controller.ViewReports();
            Console.WriteLine(reports.Count());
            var rp = reports[0].OutputPatient();
            Console.WriteLine(rp.Talk("name"));


        
        }
    }
}