using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public abstract class Diagnosis
    {
        protected Ailment ailment;
        protected Treatment treatment;

        public Diagnosis() { }

        public abstract void UpdateTreatment(IMedicalProfessional medicalPro, Treatment treatment);   

        public abstract void UpdateAilment(IMedicalProfessional medicalPro, Ailment ailment);

        public Ailment GetAilment()
        {
            return ailment;
        }

        public Treatment GetTreatment()
        {
            return treatment;
        }
    }
}
