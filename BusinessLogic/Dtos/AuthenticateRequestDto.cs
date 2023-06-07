using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Dtos
{
    public class AuthenticateRequestDto
    {
        [Required]
        public string Email { get; set; }

        //[Required]
        public string Password { get; set; }
    }
}