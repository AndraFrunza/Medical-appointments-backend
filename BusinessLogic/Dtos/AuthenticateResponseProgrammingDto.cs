﻿using Database.Entities;

namespace BusinessLogic.Dtos
{
    public class AuthenticateResponseProgrammingDto
    {
        public int Id { get; set; }

        public string Hour { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Symptom { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAdress { get; set; }
        public string DateOfBirth { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        //public string Username { get; set; }
        public string Token { get; set; }


    
    }
}
