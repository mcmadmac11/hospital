using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personnel;

namespace Structure
{
    public class Frontdesk
    {
        private MedicalProfessional user;
        public Frontdesk(MedicalProfessional user)
        {
            this.user = user;
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