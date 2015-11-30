using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    public abstract class Person
    {

        private string name = name;
        private string DOB = DOB;
        private string SSN = SSN;

        public string Talk(string question)
        {
            string answer = null;
            switch (question)
            {
                case name:
                    Console.WriteLine(name);
                    answer = name;
                    break;
                case DOB:
                    Console.WriteLine(DOB);
                    answer = DOB;
                    break;
                case SSN:
                    Console.WriteLine(SSN);
                    answer = SSN;
                    break;
            }

            return answer;

        }
    
        throw new NotImplementedException

        public void Listen(string words)
        {
            Talk(words);
        }
        throw new NotImplementedException



        




    

}
