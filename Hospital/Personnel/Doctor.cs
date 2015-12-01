using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information;

namespace Personnel
{
    public class Doctor : MedicalProfessional
    {
        public Doctor() : base() { }

        private Diagnosis Prescribe(Diagnosis diagnosis)
        {
            //doctor chooses a aingle treatment and instantiates the diagnosis with the ailment and that specific treatment
            var treatment = ChooseTreatment(diagnosis);
            diagnosis.updateTreatment(treatment);
            return diagnosis;
        }         
        
        public Diagnosis Diagnose(List<Symptom> symptoms)
        {
            ///check symptoms against ailment dictionary
            //ailment with the most symptoms == diagnosed ailment
            Ailment ailment = null; //placeholder
            var diagnosis = new Diagnosis();
            diagnosis.UpdateAilment(ailment);
            return diagnosis;
        }

        private Treatment ChooseTreatment(Diagnosis diagnosis)
        {
            var potentialTreatments = diagnosis.ailment.treatments;
            //choice logic
            var treatment = potentialTreatments[0];
            return treatment;
        }
    }

}
