using BusinessLogic.Dtos;
using Database.Entities;

namespace BusinessLogic.Mapper
{
    public static class UserMapper
    {
        public static UserEntity ToEntity(UserDto dto)
        {
            return new UserEntity 
            { 
                Id = dto.Id, 
                FirstName = dto.FirstName, 
                LastName = dto.LastName, 
                Email = dto.Email 
            };
        }

        public static UserDto ToDto(UserEntity entity)
        {
            var role = RoleMapper.ToDto(entity.Role);  
            return new UserDto 
            { 
                Id = entity.Id, 
                FirstName = entity.FirstName, 
                LastName = entity.LastName, 
                Email = entity.Email, 
                Password = entity.Password, 
                Role = role 
            };
        }
    }
}
