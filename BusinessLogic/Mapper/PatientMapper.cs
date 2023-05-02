using BusinessLogic.Dtos;
using Database.Entities;
using System.Linq;

namespace BusinessLogic.Mapper
{
   public static class PatientMapper
    {
        public static PatientEntity ToEntity(PatientDto dto, RoleEntity role)
        {
            return new PatientEntity { Id = dto.Id, User = new UserEntity { Email = dto.Email, FirstName = dto.FirstName, LastName = dto.LastName, Role = role, Id = dto.Id } };
        }

        public static PatientDto ToDto(PatientEntity entity)
        {
            var appointments = entity.Appointments.Select(x => AppointmentMapper.ToDto(x)).ToList();
            return new PatientDto { Id = entity.Id, MobilePhone = entity.MobilePhone, RoleId = entity.User.Role.Id, LastName = entity.User.LastName, FirstName = entity.User.FirstName, Email = entity.User.Email, Appointments = appointments };
        }
    }
}
