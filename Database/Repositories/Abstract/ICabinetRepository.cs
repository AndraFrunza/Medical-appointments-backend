using Database.Entities;

namespace Database.Repositories.Abstract
{
   public interface ICabinetRepository : IRepository<CabinetEntity>
    {
        CabinetEntity GetByName(string name);
    }
}
