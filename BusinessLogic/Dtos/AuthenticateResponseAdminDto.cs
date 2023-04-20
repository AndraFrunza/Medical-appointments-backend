using Database.Entities;

namespace BusinessLogic.Dtos
{
    public class AuthenticateResponseAdminDto
    {
        public int Id { get; set; }
        public string EmailAdress { get; set; }
        // public string Username { get; set; }
        public string Token { get; set; }


        public AuthenticateResponseAdminDto(AdminEntity admin, string token)
        {
            Id = admin.Id;
            EmailAdress = admin.EmailAdress;
            //Username = patient.Username;
            Token = token;
        }
    }
}
