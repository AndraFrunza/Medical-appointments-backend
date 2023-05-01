using Database.Entities;


namespace Database.Repositories.Abstract
{
    public interface IAdminRepository : IRepository<AdminEntity>
    {
        AdminEntity GetByMobilePhone(int number);
        AdminEntity GetByLastName(string lastname);
        AdminEntity GetByFirstName(string firstname);
        AdminEntity GetByEmail(string email);
    }
}
