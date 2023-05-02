using Database.Entities;

namespace BusinessLogic.Dtos
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public int Hour { get; set; }
        public string Symptom { get; set; }
        public int MobilePhone { get; set; }
        public string EmailAdress { get; set; }
        public int DateOfBirth { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public DoctorDto Doctor { get; set; }
        public PatientDto Patient { get; set; }
    }
}
