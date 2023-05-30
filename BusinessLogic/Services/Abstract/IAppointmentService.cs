using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Services.Abstract
{
   public interface IAppointmentService : IService<AppointmentDto>
    {
        AppointmentDto GetByHour(int hour);
        AppointmentDto GetBySymptom(string symptom);
        AppointmentDto GetByMobilePhone(string number);
        AppointmentDto GetByEmailAdress(string email);
        AppointmentDto GetByDateOfBirth(DateTime date);
        AppointmentDto GetByWeight(double weight);
        AppointmentDto GetByHeight(int height);
        List<AppointmentDto> GetByDoctorId(int doctorId);
        
    }
}
