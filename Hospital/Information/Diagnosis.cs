using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public class Diagnosis
    {
        public Ailment ailment { get; private set; }
        public Treatment treatment { get; private set; }

        public Diagnosis() { }

        public void updateTreatment(Treatment treatment)
        {
            this.treatment = treatment;
        }

        public void UpdateAilment(Ailment ailment)
        {
            this.ailment = ailment;
        }
    }
}
