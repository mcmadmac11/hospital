using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    public class Nurse : MedicalProfessional
    {
        public Nurse (string name, string DOB, string SSN) : base (name, DOB, SSN) { }
    }
}
