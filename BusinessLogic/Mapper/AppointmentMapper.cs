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

        public static AppointmentDto ToDto(AppointmentEntity dto)
        {
            return new AppointmentDto { Id = dto.Id, Hour = dto.Hour, Symptom = dto.Symptom, MobilePhone = dto.MobilePhone, EmailAdress = dto.EmailAdress, DateOfBirth = dto.DateOfBirth, Weight = dto.Weight, Height = dto.Height };
        }

    }
}
