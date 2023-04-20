using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Dtos
{
    public class AuthenticateRequestDoctorDto
    {
        [Required]
        public string EmailAdress { get; set; }

        [Required]
        public string Specialization { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
