using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public class Symptom
    {
        private string title;
        private string description;

        public Symptom(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
