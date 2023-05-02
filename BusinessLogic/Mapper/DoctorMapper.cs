using BusinessLogic.Dtos;
using Database.Entities;
using System.Linq;

namespace BusinessLogic.Mapper
{
    public static class DoctorMapper
    {
        public static DoctorEntity ToEntity(DoctorDto dto, RoleEntity role)
        {
            return new DoctorEntity { Id = dto.Id, Specialization = dto.Specialization, User = new UserEntity { Email = dto.Email, FirstName = dto.FirstName, LastName = dto.LastName, Role = role }  };
        }

        public static DoctorDto ToDto(DoctorEntity entity)
        {
            var appointments = entity.Appointments.Select(x => AppointmentMapper.ToDto(x)).ToList();
            var cabinet = CabinetMapper.ToDto(entity.Cabinet);
            return new DoctorDto { Id = entity.Id, Specialization = entity.Specialization, RoleId = entity.User.Role.Id, LastName = entity.User.LastName, Email = entity.User.Email, FirstName = entity.User.FirstName, Appointments = appointments, Cabinet = cabinet };
        }
    }
}