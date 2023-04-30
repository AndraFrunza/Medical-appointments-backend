using BusinessLogic.Dtos;
using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
   public static class DoctorMapper
    {
        public static DoctorEntity ToEntity(DoctorDto dto)
        {
            return new DoctorEntity { Id = dto.Id, Specialization = dto.Specialization, Cabinet = dto.Cabinet, User = dto.User, Appointments = dto.Appointments };
        }

        public static DoctorDto ToDto(DoctorEntity dto)
        {
            return new DoctorDto { Id = dto.Id, Specialization = dto.Specialization, Cabinet = dto.Cabinet, User = dto.User, Appointments = dto.Appointments };
        }
    }
}
