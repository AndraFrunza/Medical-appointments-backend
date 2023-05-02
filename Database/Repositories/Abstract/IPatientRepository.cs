using Database.Entities;

namespace Database.Repositories.Abstract
{
    public interface IPatientRepository : IRepository<PatientEntity>
    {
       PatientEntity GetByMobilePhone(int number);
    }
}
