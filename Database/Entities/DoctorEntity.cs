using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class DoctorEntity : UserEntity
    {
        public string EmailAdress { get; set; }
        public string Specialization { get; set; }
    }
}
