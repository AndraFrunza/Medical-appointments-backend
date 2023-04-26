using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
   public interface IService <T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T dto);
        T Update(T dto);
        void Delete(int id);
    }
}
