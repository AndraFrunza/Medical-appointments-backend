using Database.Entities;

namespace Database.Repositories.Abstract
{
   public interface IAppointmentRepository : IRepository<AppointmentEntity>
    {
        AppointmentEntity GetByHour(int hour);
        AppointmentEntity GetBySymptom(string symptom);
        AppointmentEntity GetByMobilePhone(string number);
        AppointmentEntity GetByEmailAdress(string email);
        AppointmentEntity GetByDateOfBirth(int date);
        AppointmentEntity GetByWeight(double weight);
        AppointmentEntity GetByHeight(int height);
    }
}
