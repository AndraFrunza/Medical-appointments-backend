using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace Database.Entities
{
    public class PatientEntity 
    {
        public int Id { get; set; }
        public int MobilePhone { get; set; }
        public UserEntity User { get; set; }

        public virtual ICollection <AppointmentEntity> Appointments { get; set; }
    }
}
