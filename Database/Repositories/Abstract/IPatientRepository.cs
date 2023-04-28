using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Abstract
{
   public interface IPatientRepository : IRepository<PatientEntity>
    {
       PatientEntity GetByMobilePhone(int number);
    }
}
