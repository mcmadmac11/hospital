using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    class Ailment
    {
        private string nameOfAilment;
        private List<Symptom> symptoms;
        private List<Treatment> treatments;

        public Ailment(string name)
        {
            nameOfAilment = name;
            symptoms = new List<Symptom>;
            treatments = new List<Treatment>;
        }

        public void UpdateSymptom(Symptom symptom)
        {
            symptoms.Add(symptom);
        }

        public void UpdateTreatment(Treatment treatment)
        {
            treatments.Add(treatment);
        }


    }
}
