using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Storage
{
    public class Database
    {
        private XmlSerializer writer;
        private XmlSerializer reader;
        private List<Report> reports = new List<Report>();

        public Database()
        {
            RefreshReports();
        }

        public List<Report> ViewReports()
        {
            RefreshReports();
            return reports;
        }

        private void RefreshReports()
        {
            reports = ReadDatabase();
        }

        public void AddReport(Report report)
        {
            RefreshReports();
            reports.Add(report);
            UpdateDatabase(reports);
        }

        private void UpdateDatabase(List<Report> reports)
        {
            writer = new XmlSerializer(reports.GetType());
            var file = new StreamWriter("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\database.xml");
            writer.Serialize(file, reports);
            file.Close();
        }

        private List<Report> ReadDatabase()
        {
            var reports = new List<Report>();
            reader = new XmlSerializer(reports.GetType());
            var file = new StreamReader("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\database.xml");
            reports = (List<Report>)reader.Deserialize(file);
            return reports;
        }
    }
}
