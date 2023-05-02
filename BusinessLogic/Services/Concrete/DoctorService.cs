using BusinessLogic.Dtos;
using BusinessLogic.Mapper;
using BusinessLogic.Services.Abstract;
using Database.Repositories.Abstract;
using System.Collections.Generic;

namespace BusinessLogic.Services.Concrete
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository repository;

        public DoctorService(IDoctorRepository repository)
        {
            this.repository = repository;
        }

        public DoctorDto Create(DoctorDto dto)
        {
            var entity = DoctorMapper.ToEntity(dto);
            entity = repository.Create(entity);
            dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<DoctorDto> GetAll()
        {
            var entities = repository.GetAll();
            var dtos = new List<DoctorDto>();
            foreach (var entity in entities)
            {
                dtos.Add(DoctorMapper.ToDto(entity));
            }
            return dtos;
        }

        public DoctorDto GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public DoctorDto GetByFirstName(string firstname)
        {
            throw new System.NotImplementedException();
        }

        public DoctorDto GetById(int id)
        {
            var entity = repository.GetById(id);
            if (entity == null)
            {
                return null;
            }
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto GetByLastName(string lastname)
        {
            throw new System.NotImplementedException();
        }

        public DoctorDto GetByMobilePhone(int number)
        {
            throw new System.NotImplementedException();
        }

        public DoctorDto GetBySpecialization(string specialization)
        {
            var entity = repository.GetBySpecialization(specialization);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto Update(DoctorDto dto)
        {
            var entity = DoctorMapper.ToEntity(dto);
            entity = repository.Update(entity);
            dto = DoctorMapper.ToDto(entity);
            return dto;
        }

    }
}
