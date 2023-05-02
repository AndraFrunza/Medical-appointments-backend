using Database.Entities;
using System.Collections.Generic;

namespace BusinessLogic.Dtos
{
   public class AdminDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public int RoleId { get; set; }
        
    }
}
