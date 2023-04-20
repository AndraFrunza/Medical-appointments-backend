using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Dtos
{
    public class AuthenticateRequestProgrammingDto
    {
        [Required]
        public string Hour { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Symptom { get; set; }

        [Required]
        public string MobilePhone { get; set; }

        [Required]
        public string EmailAdress { get; set; }

        [Required]
        public string DateOfBirth { get; set; }

        [Required]
        public string Weight { get; set; }

        [Required]
        public string Height { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
