using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;

namespace Structure
{
    abstract class Room
    {
        protected bool occupied;
        public List<Person> occupants;

        protected Room()
        {
            occupants = new List<Person>();
        }

        public void AddOccupant(Person person)
        {
            occupants.Add(person);
        }

        public void RemoveOccupant(Person person)
        {
            foreach (Person occupant in occupants)
            {
                if (person.name == occupant.name)
                {
                    //may error out since iterating mid list.
                    //other option is:
                    // personToRemove = occupants.Single( occupant => occupant.name == person.name);
                    occupants.Remove(occupant);
                }
            }
        }
    }
}
