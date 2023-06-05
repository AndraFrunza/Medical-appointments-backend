using System;

namespace BusinessLogic.Dtos
{
    public class AppointmentDto
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
        public bool Present { get; set; }
        public DoctorDto Doctor { get; set; }
        public PatientDto Patient { get; set; }
    }
}
