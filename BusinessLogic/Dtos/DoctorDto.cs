﻿using Database.Entities;
using System.Collections.Generic;

namespace BusinessLogic.Dtos
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string Specialization { get; set; }
        public CabinetDto Cabinet { get; set; }
        public List<AppointmentDto> Appointments { get; set; }

        public int MobilePhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

    }
}
