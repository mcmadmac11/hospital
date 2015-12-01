using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public class Frontdesk
    {
        private MedicalProfessional user;
        private bool userVerified;
        public Frontdesk(MedicalProfessional user)
        {
            this.user = user;
            userVerified = VerifyUser();
        }

        private bool VerifyUser()
        {
            return true;
        }

        public string Call(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void ScheduleAppointment(dynamic appointmentInfo) { }

        private void GetInsuranceInfo() { }

        private void AddPatient() { }
    }
}