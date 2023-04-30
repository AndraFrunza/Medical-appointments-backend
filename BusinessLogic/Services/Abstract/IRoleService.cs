using BusinessLogic.Dtos;

namespace BusinessLogic.Services.Interfaces
{
   public interface IRoleService : IService<RoleDto>
    {
        RoleDto GetByName(string name);
    }
}
