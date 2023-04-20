﻿using Database.Entities;

namespace BusinessLogic.Dtos
{
    public class AuthenticateResponsePatientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAdress { get; set; }
        // public string Username { get; set; }
        public string Token { get; set; }


        public AuthenticateResponsePatientDto(PatientEntity patient, string token)
        {
            Id = patient.Id;
            FirstName = patient.FirstName;
            LastName = patient.LastName;
            MobilePhone = patient.MobilePhone;
            EmailAdress = patient.EmailAdress;
            //Username = patient.Username;
            Token = token;
        }
    }
}
