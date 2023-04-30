using BusinessLogic.Dtos;
using Database.Entities;

namespace BusinessLogic.Mapper
{
   public static class AdminMapper
    {
        public static AdminEntity ToEntity(AdminDto dto)
        {
            return new AdminEntity { Id = dto.Id, User = dto.User };
        }

        public static AdminDto ToDto(AdminEntity dto)
        {
            return new AdminDto { Id = dto.Id, User = dto.User };
        }
    }
}
