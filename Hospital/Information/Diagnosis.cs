using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    class Diagnosis
    {
        Ailment ailment;
        Treatment treatment;

        public Diagnosis(Ailment ailment, Treatment treatment)
        {
            this.ailment = ailment;
            this.treatment = treatment;
        }
    }
}
