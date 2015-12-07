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
            //report writing tests

            //Console.WriteLine("No bugs!");
            //WaitingRoom room = new WaitingRoom();
            //var personFactory = new PersonFactory();


            //var p1 = personFactory.CreatePatient("Kurt", "09/03/1985");
            //var d1 = personFactory.CreateDoctor("Dr. Kim", "immortal");

            //var appointment = new Information.Appointment();
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

<<<<<<< HEAD
=======
            var single1 = new SingleSchedule {name = "Jimbo", doctorName = "Dr. Feelgood", timeOfDay= new TimeSpan(9, 20, 0), date = new DateTime(2012, 5, 8) };
            var schedules = new List<Schedule> { single1 };
>>>>>>> 45d1f173ef9a54507e527bde95975c14b3d76af7

            //calendar writing tests
            var bridge = new UICalendarBridge();
            bridge.ScheduleSingleAppointment("Simon", "Dr. Belmont", new TimeSpan(13, 20, 0), new DateTime(2015, 12, 8) );

            //Period period = new Period (new DateTime(2012, 5, 1), new DateTime(2012, 5, 9));
            var appointments = bridge.GetCalendar();

            foreach (var appointment in appointments)
            {
                Console.WriteLine("{0} | {1} with {2}", appointment.time.ToString("yyyy-MM-dd HH:mm"), appointment.name, appointment.doctorName);
            }


        }
    }
}