using BusinessLogic.Dtos;
using Database.Entities;

namespace BusinessLogic.Mapper
{
   public static class AdminMapper
    {
        public static AdminEntity ToEntity(AdminDto dto, RoleEntity role)
        {
            return new AdminEntity 
            { 
                Id = dto.Id, 
                User = new UserEntity 
                { 
                    Email = dto.Email, 
                    FirstName = dto.FirstName, 
                    LastName = dto.LastName, 
                    Id = dto.Id, 
                    Role = role
                } 
            };
        }

        public static AdminDto ToDto(AdminEntity entity)
        {
            return new AdminDto 
            { 
                Id = entity.Id, 
                Email = entity.User.Email, 
                FirstName = entity.User.FirstName, 
                LastName = entity.User.LastName, 
                RoleId = entity.User.Role.Id  
            };
        }
    }
}
