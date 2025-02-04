﻿using System.Text.Json.Serialization;


namespace Database.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public RoleEntity Role { get; set; }


        [JsonIgnore]
        public string Password { get; set; }
    }
}
