using Database.Entities;
using System.Collections.Generic;

namespace BusinessLogic.Dtos
{
   public class CabinetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DoctorEntity> Doctors { get; set; }
    }
}
