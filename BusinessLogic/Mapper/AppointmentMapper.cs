using BusinessLogic.Dtos;
using Database.Entities;

namespace BusinessLogic.Mapper
{
   public static class AppointmentMapper
    {
        public static AppointmentEntity ToEntity(AppointmentDto dto)
        {
            return new AppointmentEntity { Id = dto.Id, Hour = dto.Hour, Symptom = dto.Symptom, MobilePhone = dto.MobilePhone, EmailAdress = dto.EmailAdress, DateOfBirth = dto.DateOfBirth, Weight = dto.Weight, Height = dto.Height };
        }

        public static AppointmentDto ToDto(AppointmentEntity entity)
        {
            return new AppointmentDto { Id = entity.Id, Hour = entity.Hour, Symptom = entity.Symptom, MobilePhone = entity.MobilePhone, EmailAdress = entity.EmailAdress, DateOfBirth = entity.DateOfBirth, Weight = entity.Weight, Height = entity.Height, Doctor = DoctorMapper.ToDto(entity.Doctor), Patient = PatientMapper.ToDto(entity.Patient) };
        }

    }
}
