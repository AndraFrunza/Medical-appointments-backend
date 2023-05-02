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
        private readonly IRoleRepository roleRepository;

        public DoctorService(IDoctorRepository repository, IRoleRepository roleRepository)
        {
            this.repository = repository;
            this.roleRepository = roleRepository;
        }

        public DoctorDto Create(DoctorDto dto)
        {
            var role = roleRepository.GetById(dto.RoleId);
            var doctor = DoctorMapper.ToEntity(dto, role);
            doctor = repository.Create(doctor);
            dto = DoctorMapper.ToDto(doctor);
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
            var entity = repository.GetBySpecialization(email);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto GetByFirstName(string firstname)
        {
            var entity = repository.GetBySpecialization(firstname);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
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
            var entity = repository.GetBySpecialization(lastname);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto GetByMobilePhone(string number)
        {
            var entity = repository.GetBySpecialization(number);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto GetBySpecialization(string specialization)
        {
            var entity = repository.GetBySpecialization(specialization);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto Update(DoctorDto dto)
        {
            var role = roleRepository.GetById(dto.RoleId);
            var doctor = DoctorMapper.ToEntity(dto, role);
            doctor = repository.Update(doctor);
            dto = DoctorMapper.ToDto(doctor);
            return dto;
        }

    }
}
