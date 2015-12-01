using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    public class PersonFactory
    {
        public PersonFactory() { }

        public Patient CreatePatient(string name, params dynamic[] info)
        {
            var patient = new Patient();
            patient.SetInformation(name, info);
            return patient;
        }

        public Nurse CreateNurse(string name, params dynamic[] info)
        {
            var nurse = new Nurse();
            nurse.SetInformation(name, info);
            return nurse;
        }

        public Doctor CreateDoctor(string name, params dynamic[] info)
        {
            var doctor = new Doctor();
            doctor.SetInformation(name, info);
            return doctor;
        }

        public MedicalProfessional CreateMedicalProfessional(string name, params dynamic[] info)
        {
            var medicalPro = new MedicalProfessional();
            medicalPro.SetInformation(name,info);
            return medicalPro;
        }
    }
}