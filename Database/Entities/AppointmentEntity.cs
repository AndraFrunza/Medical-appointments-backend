using System;

namespace Database.Entities
{
    public class AppointmentEntity 
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public string Symptom { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAdress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public DoctorEntity Doctor { get; set; }
        public PatientEntity Patient { get; set; }

    }
}
