using BusinessLogic.Dtos;
using Database.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Mapper
{
    public static class DoctorMapper
    {
        public static DoctorEntity ToEntity(DoctorDto dto, RoleEntity role, CabinetEntity cabinet)
        { 
            return new DoctorEntity
            {
                Id = dto.Id,
                Specialization = dto.Specialization,
                Cabinet = cabinet,
                MobilePhone = dto.MobilePhone,
                User = new UserEntity 
                {
                    Email = dto.Email,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Role = role
                }  
            };
        }

        public static DoctorDto ToDto(DoctorEntity entity)
        {

            var cabinet = CabinetMapper.ToDto(entity.Cabinet);

            return new DoctorDto
            {
                Id = entity.Id,
                Specialization = entity.Specialization,
                RoleId = entity.User.Role.Id,
                LastName = entity.User.LastName,
                Email = entity.User.Email,
                FirstName = entity.User.FirstName,
                Cabinet = cabinet,
                MobilePhone = entity.MobilePhone
            };
        }
    }
}