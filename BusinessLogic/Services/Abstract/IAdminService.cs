using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;

namespace BusinessLogic.Services.Abstract
{
   public interface IAdminService : IService<AdminDto>
    {
        AdminDto GetByMobilePhone(int number);
        AdminDto GetByFirstName(string firstname);
        AdminDto GetByLastName(string lastname);
        AdminDto GetByEmail(string email);
    }
}
