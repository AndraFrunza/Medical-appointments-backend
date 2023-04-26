using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class CabinetEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DoctorEntity> Doctors { get; set; }
    }
}
