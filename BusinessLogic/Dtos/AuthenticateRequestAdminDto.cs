using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Dtos
{
    public class AuthenticateRequestAdminDto
    {
        [Required]
        public string EmailAdress { get; set; }
    }
}
