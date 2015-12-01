using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    class Treatment
    {
        private string nameOfTreatment;
        private string info;

        public Treatment(string name)
        {
            nameOfTreatment = name;
        }

        public void modifyTreatmentInfo(string info)
        {
            this.info = info;
        }
    }
}
