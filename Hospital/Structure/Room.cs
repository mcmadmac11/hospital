using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    abstract class Room
    {
        protected bool occupied;
        public List<Person> occupants;

        protected Room()
        {
            occupants = new List<dynamic>();
        }

        protected void AddOccupant(Person occupant)
        {
            occupants.Add(occupants);
        }
    }
}
