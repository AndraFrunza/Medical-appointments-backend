using BusinessLogic.Dtos;
using Database.Entities;

namespace BusinessLogic.Mapper
{
   public static class RoleMapper
    {
        public static RoleEntity ToEntity(RoleDto dto)
        {
            return new RoleEntity { Id = dto.Id, Name = dto.Name };
        }

        public static RoleDto ToDto(RoleEntity entity)
        {
            return new RoleDto { Id = entity.Id, Name = entity.Name };
        }
    }
}
