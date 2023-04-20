using System.Text.Json.Serialization;


namespace Database.Entities
{
    public class PatientEntity : UserEntity
    {
        public string MobilePhone { get; set; }

        public string EmailAdress { get; set; }
    }
}
