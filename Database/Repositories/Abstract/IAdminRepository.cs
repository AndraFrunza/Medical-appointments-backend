using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Abstract
{
    public interface IAdminRepository
    {
        AdminEntity Create(AdminEntity admin);
        void Delete(int id);
        object GetAll();
        object GetById(int id);
    }
}
