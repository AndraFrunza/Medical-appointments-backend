using System.Collections.Generic;

namespace BusinessLogic.Dtos
{
    public class PatientDto
    {
        public int Id { get; set; }
        public string MobilePhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public int RoleId { get; set; }
        public List<AppointmentDto> Appointments { get; set; }
    }
}
