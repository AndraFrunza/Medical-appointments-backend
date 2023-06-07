using BusinessLogic.Dtos;
using Database.Entities;
using System.Collections.Generic;

namespace BusinessLogic.Mapper
{
   public static class AppointmentMapper
    {
        public static AppointmentEntity ToEntity(AppointmentDto dto, DoctorEntity doctor, PatientEntity patient)
        {
            
            return new AppointmentEntity 
            { 
              
                Hour = dto.Hour,
                Date = dto.Date,
                Symptom = dto.Symptom, 
                MobilePhone = dto.MobilePhone, 
                EmailAdress = dto.EmailAdress, 
                DateOfBirth = dto.DateOfBirth, 
                Present = dto.Present,
                Id = dto.Id,
                Tratament = dto.Tratament,
                Weight = dto.Weight, 
                Height = dto.Height ,
                Doctor = doctor,
                Patient = patient
            };
        }

        public static AppointmentDto ToDto(AppointmentEntity entity)
        {
            var doctor = DoctorMapper.ToDto(entity.Doctor);
            var patient = PatientMapper.ToDto(entity.Patient);
            return new AppointmentDto 
            { 
                Id = entity.Id, 
                Date = entity.Date,
                Hour = entity.Hour, 
                Symptom = entity.Symptom, 
                MobilePhone = entity.MobilePhone, 
                Present = entity.Present,
                EmailAdress = entity.EmailAdress, 
                DateOfBirth = entity.DateOfBirth, 
                Tratament = entity.Tratament,
                Weight = entity.Weight, 
                Height = entity.Height, 
                Doctor = doctor, 
                Patient = patient 
            };
        }

    }
}
