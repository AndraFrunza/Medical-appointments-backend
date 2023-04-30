using BusinessLogic.Dtos;
using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
    public static class UserMapper
    {
        public static UserEntity ToEntity(UserDto dto)
        {
            return new UserEntity { Id = dto.Id, FirstName = dto.FirstName, LastName = dto.LastName, Email = dto.Email, Password = dto.Password, Role = dto.Role };
        }

        public static UserDto ToDto(UserEntity dto)
        {
            return new UserDto { Id = dto.Id, FirstName = dto.FirstName, LastName = dto.LastName, Email = dto.Email, Password = dto.Password, Role = dto.Role };
        }
    }
}
