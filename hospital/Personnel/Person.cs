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

        protected Person()
        {
            this.name = null;
            this.DOB = null;
            this.SSN = null;
            this.insurance = null;
        }

        public void SetInformation(string name, params dynamic[] info)
        {
            SetName(name);
            for (int i=0; i < info.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        SetDOB(info[i]);
                        break;
                    case 1:
                        setSSN(info[i]);
                        break;
                    case 2:
                        setInsurance(info[i]);
                        break;
                }
            }
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDOB(string DOB)
        {
            this.DOB = DOB;
        }

        public void setSSN(string SSN)
        {
            this.SSN = SSN;
        }

        public void setInsurance(Insurance insurance)
        {
            this.insurance = insurance;
        }

        public dynamic Talk(string question)
        {
            dynamic answer = null;
            switch (question)
            {
                case "name":
                    answer = name;
                    break;
                case "dob":
                    answer = DOB;
                    break;
                case "ssn":
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
