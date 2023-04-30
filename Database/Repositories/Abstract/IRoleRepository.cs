using Database.Entities;

namespace Database.Repositories.Abstract
{
   public interface IRoleRepository : IRepository<RoleEntity>
    {
        RoleEntity GetByName(string name);
    }
}
