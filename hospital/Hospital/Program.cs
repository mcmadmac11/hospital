using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;
using Structure;
using Information;
using Storage;
using Calendar;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("No bugs!");
            //WaitingRoom room = new WaitingRoom();
            //var personFactory = new PersonFactory();
          

            //var p1 = personFactory.CreatePatient("Liam", "09/02/1985");
            //var d1 = personFactory.CreateDoctor("Dr. Fong", "immortal");
          
            //var appointment = new Appointment();
            //appointment.Initialize("12:00", "10/5/2016", p1.Talk("name"), d1.Talk("name"));
            //var diagnosis = "ebola";

            //var report = new Report(p1, appointment, diagnosis);
            //Console.WriteLine(report.OutputPatient().Talk("name"));
            //Console.WriteLine(report.OutputDiagnosis());

            //Database controller = new Database();
            //var ReportXML = report.ConstructReportXML();
            //controller.AddReport(ReportXML);

            //var r = controller.ViewReports();
            //var newReport = r[0].ReconstructReport();

            //Console.WriteLine(newReport.OutputPatient().Talk("name"));
            //Console.WriteLine(report.OutputDiagnosis());

            var single1 = new SingleSchedule {name = "Jimbo", doctorName = "Dr. Feelgood", timeOfDay= new TimeSpan(9, 20, 0), date = new DateTime(2012, 5, 8) };
            var schedules = new List<Schedule> { single1 };

            CalendarGenerator generator = new CalendarGenerator();
            Period period = new Period (new DateTime(2012, 5, 1), new DateTime(2012, 6, 30));
            var appointments = generator.GenerateCalendar(period, schedules);

            foreach (var appointment in appointments)
            {
                Console.WriteLine("{0} | {1} with {2}", appointment.time.ToString("yyyy-MM-dd HH:mm"), appointment.name, appointment.doctorName);
            }

        
        }
    }
}