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


        public AuthenticateResponseDoctorDto(DoctorEntity doctor, string token)
        {
            Id = doctor.Id;
            EmailAdress = doctor.EmailAdress;
            Specialization = doctor.Specialization;
            //Username = patient.Username;
            Token = token;
        }
    }
}
