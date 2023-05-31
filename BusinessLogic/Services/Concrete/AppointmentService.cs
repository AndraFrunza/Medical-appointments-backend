using BusinessLogic.Dtos;
using BusinessLogic.Helpers;
using BusinessLogic.Mapper;
using BusinessLogic.Services.Abstract;
using Database.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Services.Concrete
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository repository;
        private readonly IDoctorRepository doctorRepository;
        private readonly IPatientRepository patientRepository;

        public AppointmentService(IAppointmentRepository repository, IDoctorRepository doctorRepository, IPatientRepository patientRepository)
        {
            this.repository = repository;
            this.doctorRepository = doctorRepository;
            this.patientRepository = patientRepository;
        }

        public AppointmentDto Create(AppointmentDto dto)
        {
            var doctor = doctorRepository.GetById(dto.Doctor.Id);
            var patient = patientRepository.GetById(dto.Patient.Id);
            var entity = AppointmentMapper.ToEntity(dto, doctor, patient);
            var appointments = repository.GetByDoctorId(doctor.Id);
            if (appointments.Any(appointment => appointment.Date == dto.Date && appointment.Hour == dto.Hour)) 
            {
                throw new AppointmentException("Exista deja o programare la aceasta ora");
            }
            entity = repository.Create(entity);
            dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<AppointmentDto> GetAll()
        {
            var entities = repository.GetAll();
            var dtos = new List<AppointmentDto>();
            foreach (var entity in entities)
            {
                dtos.Add(AppointmentMapper.ToDto(entity));
            }
            return dtos;
        }

        public List<AppointmentDto> GetAppointmentsByDoctorId(int medicId)
        {
            var entities = repository.GetAppointmentsByDoctorId(medicId);
            var dtos = new List<AppointmentDto>();
            foreach (var entity in entities)
            {
                dtos.Add(AppointmentMapper.ToDto(entity));
            }
            return dtos;
        }

        public List<AppointmentDto> GetAppointmentsByPatientId(int patientId)
        {
            var entities = repository.GetAppointmentsByPatientId(patientId);
            var dtos = new List<AppointmentDto>();
            foreach (var entity in entities)
            {
                dtos.Add(AppointmentMapper.ToDto(entity));
            }
            return dtos;
        }

        public AppointmentDto GetByDateOfBirth(DateTime date)
        {
            var entity = repository.GetByDateOfBirth(date);
            var dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public List<AppointmentDto> GetByDoctorId(int doctorId)
        {
            var entities = repository.GetByDoctorId(doctorId);
            var dtos = new List<AppointmentDto>();
            foreach (var entity in entities)
            {
                dtos.Add(AppointmentMapper.ToDto(entity));
            }
            return dtos;
        }

        public AppointmentDto GetByEmailAdress(string email)
        {
            var entity = repository.GetByEmailAdress(email);
            var dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public AppointmentDto GetByHeight(int height)
        {
            var entity = repository.GetByHeight(height);
            var dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public AppointmentDto GetByHour(int hour)
        {
            var entity = repository.GetByHour(hour);
            var dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public AppointmentDto GetById(int id)
        {
            var entity = repository.GetById(id);
            if (entity == null)
            {
                return null;
            }
            var dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public AppointmentDto GetByMobilePhone(string number)
        {
            var entity = repository.GetByMobilePhone(number);
            var dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public AppointmentDto GetBySymptom(string symptom)
        {
            var entity = repository.GetBySymptom(symptom);
            var dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public AppointmentDto GetByWeight(double weight)
        {
            var entity = repository.GetByWeight(weight);
            var dto = AppointmentMapper.ToDto(entity);
            return dto;
        }

        public AppointmentDto Update(AppointmentDto dto)
        {
            var doctor = doctorRepository.GetById(dto.Doctor.Id);
            var patient = patientRepository.GetById(dto.Patient.Id);
            var entity = AppointmentMapper.ToEntity(dto, doctor, patient);
            entity = repository.Update(entity);
            dto = AppointmentMapper.ToDto(entity);
            return dto;
        }
    }
}
