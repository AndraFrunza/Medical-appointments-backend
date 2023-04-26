using BusinessLogic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
   public interface IRoleService : IService<RoleDto>
    {
        RoleDto GetByName(string name);
    }
}
