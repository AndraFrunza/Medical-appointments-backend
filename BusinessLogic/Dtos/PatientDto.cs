using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Dtos
{
   public class PatientDto
    {
        public int Id { get; set; }
        public int MobilePhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public RoleEntity Role { get; set; }

        public List<AppointmentDto> Appointments { get; set; }
    }
}
