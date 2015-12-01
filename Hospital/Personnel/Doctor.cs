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

        private Diagnosis Prescribe(DoctorDiagnosis diagnosis)
        {
            //doctor chooses a aingle treatment and instantiates the diagnosis with the ailment and that specific treatment
            var treatment = ChooseTreatment(diagnosis);
            diagnosis.UpdateTreatment(this, treatment);
            return diagnosis;
        }         
        
        public Diagnosis Diagnose(List<Symptom> symptoms)
        {
            ///check symptoms against ailment dictionary
            //ailment with the most symptoms == diagnosed ailment
            Ailment ailment = null; //placeholder
            var diagnosis = new DoctorDiagnosis();
            diagnosis.UpdateAilment(this, ailment);
            return diagnosis;
        }

        private Treatment ChooseTreatment(DoctorDiagnosis diagnosis)
        {
            var ailment = diagnosis.GetAilment();
            var potentialTreatments = diagnosis.GetAilment().treatments;
            //choice logic
            var treatment = potentialTreatments[0];
            return treatment;
        }

        private class DoctorDiagnosis : Diagnosis
        {
            public DoctorDiagnosis() { }

            public override void UpdateTreatment(IMedicalProfessional doctor, Treatment treatment)
            {
                this.treatment = treatment;
            }

            public override void UpdateAilment(IMedicalProfessional doctor, Ailment ailment)
            {
                this.ailment = ailment;
            }
        }
    }

}
