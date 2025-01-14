﻿using Database.Entities;

namespace Database.Repositories.Abstract
{
    public interface IPatientRepository : IRepository<PatientEntity>
    {
       PatientEntity GetByMobilePhone(string number);
        PatientEntity GetPatientByUserId(int userId);
    }
}
