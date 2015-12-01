using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information;
namespace Personnel
{
    public class Patient : Person
    {
        private bool hasInsurance { get; set; }

        public Patient(string name, string DOB, string SSN, Insurance insurance) : base (name, DOB, SSN, insurance) { }
    }



}       
