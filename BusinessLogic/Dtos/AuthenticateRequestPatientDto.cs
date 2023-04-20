﻿using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Dtos
{
    public class AuthenticateRequestPatientDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string MobilePhone { get; set; }

        [Required]
        public string EmailAdress { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
