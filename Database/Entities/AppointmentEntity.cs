using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class AppointmentEntity 
    {
        public int Id { get; set; }
        public int Hour { get; set; }
        public string Symptom { get; set; }
        public int MobilePhone { get; set; }
        public string EmailAdress { get; set; }
        public int DateOfBirth { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public DoctorEntity Doctor { get; set; }
        public PatientEntity Patient { get; set; }

    }
}
