using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;
using Structure;
using Information;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No bugs!");
            WaitingRoom room = new WaitingRoom();
            Patient p1 = new Patient();
            p1.SetInformation("Sam", "09/01/1990", "none");
            Patient p2 = new Patient();
            p2.SetInformation("Jane", "sep1", "666");
            room.AddOccupant(p1, p2); 
            Console.WriteLine(room.occupants[0].name);
            Console.WriteLine(room.occupants[1].name);
            Console.WriteLine(room.occupants.Count());
            var tester = (object)p1;
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(tester.GetType());
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\chris\\github\\hospital\\Hospital\\Hospital\\test.xml");
            writer.Serialize(file, tester);
            file.Close();

        
        }
    }
}
