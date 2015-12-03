using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Storage
{
    public class Database
    {
        private XmlSerializer serializer;
        public Report reports;

        public Database()
        {
            //ReadRefresh();
        }

        public Report ViewReports()
        {
            ReadRefresh();
            return reports;
        }


        public void AddReport(Report report)
        {
            //RefreshReports();
            //reports.Add(report);
            this.reports = report;
            Console.WriteLine("added report");
            //Console.WriteLine(reports.Count());
            UpdateDatabase();
        }

        private void UpdateDatabase()
        {
            //serializer = new XmlSerializer(reports.GetType());
            //var stringWriter = new StringWriter();
            //var xmlWriter = XmlWriter.Create(stringWriter);
            //var file = new StreamWriter("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\database.xml");
            using (var file = new StreamWriter("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\database.xml"))
            {
                serializer = new XmlSerializer(reports.GetType());
                serializer.Serialize(file, reports);
                file.Flush();
            }
            //file.Close();
        }

        private void ReadRefresh()
        {
            //var file = new FileStream("link", FileMode.Open, FileAccess.Read, FileShare.Read);
            //var file = new StreamReader("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\database.xml");
            using (var file = new StreamReader("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\database.xml"))
                reports = (Report)serializer.Deserialize(file);
        }
    }
}
