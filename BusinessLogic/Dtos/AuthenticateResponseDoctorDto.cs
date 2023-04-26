using Database.Entities;

namespace BusinessLogic.Dtos
{
    public class AuthenticateResponseDoctorDto
    {
        public int Id { get; set; }
        public string EmailAdress { get; set; }
        public string Specialization { get; set; }

        // public string Username { get; set; }
        public string Token { get; set; }


      
    }
}
