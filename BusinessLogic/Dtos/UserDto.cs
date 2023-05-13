using Database.Entities;
using System.Text.Json.Serialization;

namespace BusinessLogic.Dtos
{
   public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public RoleDto Role { get; set; }


        [JsonIgnore]
        public string Password { get; set; }
    }
}
