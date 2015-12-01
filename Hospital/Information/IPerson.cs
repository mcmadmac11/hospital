using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public interface IPerson
    {
        dynamic Talk(string question);

        void Listen(string words);
    }
}
