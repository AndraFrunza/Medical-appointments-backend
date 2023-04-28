using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Abstract
{
   public  interface IPatientService : IService<PatientDto>
    {
        PatientDto GetByMobilePhone(int number);
    }
}
