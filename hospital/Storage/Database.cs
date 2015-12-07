using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Calendar;
using System.Reflection;
using System.Collections;

namespace Storage
{
    public class Database
    {
        private XmlSerializer serializer;
        private XmlSerializer reader;
        private List<ReportXML> reports;
        public List<Appointment> schedule;

        public Database()
        {
            ReadRefresh();
        }

        public List<ReportXML> ViewReports()
        {
            ReadRefresh();
            return reports;
        }

        public void AddReport(ReportXML report)
        {
            ReadRefresh();
            reports.Add(report);
            Console.WriteLine("added report");
            UpdateDatabase();
        }

        private void UpdateReports()
        {
            using (var file = new StreamWriter("C:\\Users\\phantom\\github\\hospital\\Hospital\\Hospital\\database.xml")) //change location to location on local machine running program
            {
                serializer = new XmlSerializer(reports.GetType());
                serializer.Serialize(file, reports);
                file.Flush();
            }
        }

        private void UpdateSchedule()
        {
            using (var file = new StreamWriter("C:\\Users\\phantom\\github\\hospital\\Hospital\\Hospital\\calendar.xml")) //change location to location on local machine running program
            {
                serializer = new XmlSerializer(schedule.GetType());
                serializer.Serialize(file, schedule);
                file.Flush();
            }
        }

        public void UpdateDatabase()
        {
           UpdateReports();
           UpdateSchedule();
        }

        private void ReadRefresh()
        {
            ReadReports();
            ReadSchedule();
        }

        private void ReadReports()
        {
            using (var file = new StreamReader("C:\\Users\\phantom\\github\\hospital\\Hospital\\Hospital\\database.xml")) //change location to location on local machine running program
            {
                reader = new XmlSerializer(typeof(List<ReportXML>));
                reports = (List<ReportXML>)reader.Deserialize(file);
            }
        }
        
        private void ReadSchedule()
        {
            using (var file = new StreamReader("C:\\Users\\phantom\\github\\hospital\\Hospital\\Hospital\\calendar.xml")) //change location to location on local machine running program
            {
                reader = new XmlSerializer(typeof(List<Appointment>));
                schedule = (List<Appointment>)reader.Deserialize(file);
            }
        }
    }
}
