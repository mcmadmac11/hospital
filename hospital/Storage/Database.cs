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
        private XmlSerializer reader;
        public List<ReportXML> reports;

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
            using (var file = new StreamWriter("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\database.xml"))
            {
                serializer = new XmlSerializer(reports.GetType());
                serializer.Serialize(file, reports);
                file.Flush();
            }
        }

        private void UpdateDatabase()
        {
           UpdateReports();
        }

        private void ReadRefresh()
        {
            ReadReports();
        }

        private void ReadReports()
        {
            using (var file = new StreamReader("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\database.xml"))
            {
                reader = new XmlSerializer(typeof(List<ReportXML>));
                reports = (List<ReportXML>)reader.Deserialize(file);
            }
        }
    }
}
