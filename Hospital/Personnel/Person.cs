using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information;

namespace Personnel
{
    public abstract class Person : IPerson
    {
        protected string name;
        protected string DOB;
        protected string SSN;
        protected Insurance insurance;

        protected Person(string name, string DOB, string SSN, Insurance insurance = null)
        {
            this.name = name;
            this.DOB = DOB;
            this.SSN = SSN;
            this.insurance = insurance;
        }

        public dynamic Talk(string question)
        {
            dynamic answer = null;
            switch (question)
            {
                case "name":
                   // Console.WriteLine(name);
                    answer = name;
                    break;
                case "dob":
                   // Console.WriteLine(DOB);
                    answer = DOB;
                    break;
                case "ssn":
                   // Console.WriteLine(SSN);
                    answer = SSN;
                    break;
                case "insurance":
                    answer = insurance;
                    break;
            }
            return answer;
        }
    

        public void Listen(string words)
        {
            words = words.ToLower();
            Talk(words);
        }
    }
}
