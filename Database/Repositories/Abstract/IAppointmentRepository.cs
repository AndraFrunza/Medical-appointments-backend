using Database.Entities;
using System;
using System.Collections.Generic;

namespace Database.Repositories.Abstract
{
   public interface IAppointmentRepository : IRepository<AppointmentEntity>
    {
        AppointmentEntity GetByHour(int hour);
        AppointmentEntity GetBySymptom(string symptom);
        AppointmentEntity GetByMobilePhone(string number);
        AppointmentEntity GetByEmailAdress(string email);
        AppointmentEntity GetByDateOfBirth(DateTime date);
        AppointmentEntity GetByWeight(double weight);
        AppointmentEntity GetByHeight(int height);
        List<AppointmentEntity> GetByDoctorId(int doctorId);
        List<AppointmentEntity> GetAppointmentsByPatientId(int patientId);
        List<AppointmentEntity> GetAppointmentsByDoctorId(int medicId);
    }
}
