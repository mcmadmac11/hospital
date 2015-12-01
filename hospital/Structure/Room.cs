using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;

namespace Structure
{
    public abstract class Room
    {
        protected bool occupied;
        public List<Person> occupants { get; private set; }

        protected Room()
        {
            occupants = new List<Person>();
        }

        public void AddOccupant(params Person[] persons)
        {
            foreach (Person person in persons)
            {
                occupants.Add(person);
            }
        }

        public void RemoveOccupant(Person person)
        {
            var personName = person.Talk("name");
            foreach (Person occupant in occupants)
            {
                var occupantName = occupant.Talk("name");
                if (personName == occupantName)
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
