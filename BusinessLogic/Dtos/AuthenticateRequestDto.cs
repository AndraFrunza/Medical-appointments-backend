using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Dtos
{
    public class AuthenticateRequestDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}