using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class DoctorEntity 
    {
        public int Id { get; set; }
        public UserEntity User { get; set; }
        public string Specialization { get; set; }
        public CabinetEntity Cabinet { get; set; }
        public virtual ICollection<AppointmentEntity> Appointments { get; set; }
    }
}
