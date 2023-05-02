using Database.Entities;


namespace Database.Repositories.Abstract
{
    public interface IAdminRepository : IRepository<AdminEntity>
    {
        AdminEntity GetByMobilePhone(string number);
        AdminEntity GetByLastName(string lastname);
        AdminEntity GetByFirstName(string firstname);
        AdminEntity GetByEmail(string email);
    }
}
