using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;

namespace BusinessLogic.Services.Abstract
{
   public interface IAppointmentService : IService<AppointmentDto>
    {
        AppointmentDto GetByHour(int hour);
        AppointmentDto GetBySymptom(string symptom);
        AppointmentDto GetByMobilePhone(string number);
        AppointmentDto GetByEmailAdress(string email);
        AppointmentDto GetByDateOfBirth(int date);
        AppointmentDto GetByWeight(double weight);
        AppointmentDto GetByHeight(int height);
        
    }
}
