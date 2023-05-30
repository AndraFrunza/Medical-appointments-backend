using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;
using System.Collections.Generic;

namespace BusinessLogic.Services.Abstract
{
   public interface IDoctorService : IService<DoctorDto>
    {
        DoctorDto GetBySpecialization(string specialization);
        DoctorDto GetByMobilePhone(string number);
        DoctorDto GetByFirstName(string firstname);
        DoctorDto GetByLastName(string lastname);
        DoctorDto GetByEmail(string email);
        List<DoctorDto> GetByCabinetId(int cabinet);
        DoctorDto GetDoctorByUserId(int userId);
    }
}
