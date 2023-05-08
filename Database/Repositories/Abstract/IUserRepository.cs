using Database.Entities;

namespace Database.Repositories.Abstract
{
   public interface IUserRepository : IRepository<UserEntity>
    {
        UserEntity GetByFirstName(string firstname);
        UserEntity GetByLastName(string lastname);
        UserEntity GetByEmail(string email);
        UserEntity GetByPassword(string password);
        
    }
}
