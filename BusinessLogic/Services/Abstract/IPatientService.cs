using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;

namespace BusinessLogic.Services.Abstract
{
    public  interface IPatientService : IService<PatientDto>
    {
        PatientDto GetByMobilePhone(string number);
    }
}
