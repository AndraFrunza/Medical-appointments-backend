using BusinessLogic.Dtos;
using BusinessLogic.Mapper;
using BusinessLogic.Services.Abstract;
using Database.Repositories.Abstract;
using System.Collections.Generic;

namespace BusinessLogic.Services.Concrete
{
   public class PatientService : IPatientService
    {
        private readonly IPatientRepository repository;

        public PatientService(IPatientRepository repository)
        {
            this.repository = repository;
        }

        public PatientDto Create(PatientDto dto)
        {
            var patient = PatientMapper.ToEntity(dto);
            patient = repository.Create(patient);
            dto = PatientMapper.ToDto(patient);
            return dto;
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<PatientDto> GetAll()
        {
            var patients = repository.GetAll();
            var dtos = new List<PatientDto>();
            foreach (var patient in patients)
            {
                dtos.Add(PatientMapper.ToDto(patient));
            }
            return dtos;
        }

        public PatientDto GetById(int id)
        {
            var patient = repository.GetById(id);
            if (patient == null)
            {
                return null;
            }
            var dto = PatientMapper.ToDto(patient);
            return dto;
        }

        public PatientDto GetByMobilePhone(int number)
        {
            var patient = repository.GetByMobilePhone(number);
            var dto = PatientMapper.ToDto(patient);
            return dto;
        }

        public PatientDto Update(PatientDto dto)
        {
            var patient = PatientMapper.ToEntity(dto);
            patient = repository.Update(patient);
            dto = PatientMapper.ToDto(patient);
            return dto;
        }
    }
}
