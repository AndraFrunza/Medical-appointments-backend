using System.Collections.Generic;

namespace Database.Entities
{
    public class DoctorEntity 
    {
        public int Id { get; set; }
        public UserEntity User { get; set; }
        public string MobilePhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Specialization { get; set; }
        public CabinetEntity Cabinet { get; set; }
        public virtual ICollection<AppointmentEntity> Appointments { get; set; }
    }
}
