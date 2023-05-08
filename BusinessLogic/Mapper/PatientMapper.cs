using BusinessLogic.Dtos;
using Database.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Mapper
{
   public static class PatientMapper
    {
        public static PatientEntity ToEntity(PatientDto dto, RoleEntity role)
        {
            return new PatientEntity 
            { 
                Id = dto.Id, 
                MobilePhone = dto.MobilePhone,
                User = new UserEntity 
                { 
                    Email = dto.Email, 
                    FirstName = dto.FirstName, 
                    LastName = dto.LastName, 
                    Role = role, 
                    Id = dto.Id 
                } 
            };
        }

        public static PatientDto ToDto(PatientEntity entity)
        {
           

            return new PatientDto 
            { 
                Id = entity.Id, 
                MobilePhone = entity.MobilePhone, 
                RoleId = entity.User.Role.Id, 
                LastName = entity.User.LastName, 
                FirstName = entity.User.FirstName, 
                Email = entity.User.Email, 
                
            };
        }
    }
}
