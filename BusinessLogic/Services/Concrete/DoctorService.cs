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
        private readonly ICabinetRepository cabinetRepository;

        public DoctorService(IDoctorRepository repository, IRoleRepository roleRepository, ICabinetRepository cabinetRepository)
        {
            this.repository = repository;
            this.roleRepository = roleRepository;
            this.cabinetRepository = cabinetRepository;

        }

        public DoctorDto Create(DoctorDto dto)
        {
            var cabinet = cabinetRepository.GetById(dto.Cabinet.Id);
            var role = roleRepository.GetById(dto.RoleId);
            var doctor = DoctorMapper.ToEntity(dto, role, cabinet);
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

        public List<DoctorDto> GetByCabinetId(int cabinet)
        {
            var entities = repository.GetByCabinetId(cabinet);
            var dtos = new List<DoctorDto>();
            foreach (var entity in entities)
            {
                dtos.Add(DoctorMapper.ToDto(entity));
            }
            return dtos;
        }

        public DoctorDto GetByEmail(string email)
        {
            var entity = repository.GetByEmail(email);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto GetByFirstName(string firstname)
        {
            var entity = repository.GetByFirstName(firstname);
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
            var entity = repository.GetByLastName(lastname);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto GetByMobilePhone(string number)
        {
            var entity = repository.GetByMobilePhone(number);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto GetBySpecialization(string specialization)
        {
            var entity = repository.GetBySpecialization(specialization);
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }

        public DoctorDto GetDoctorByUserId(int userId)
        {
            var entity = repository.GetDoctorByUserId(userId);
            if(entity != null){ 
            var dto = DoctorMapper.ToDto(entity);
            return dto;
        }
            return null;
        }

        public DoctorDto Update(DoctorDto dto)
        {
            var cabinet = cabinetRepository.GetById(dto.Cabinet.Id);
            var role = roleRepository.GetById(dto.RoleId);
            var doctor = DoctorMapper.ToEntity(dto, role, cabinet);
            doctor = repository.Update(doctor);
            dto = DoctorMapper.ToDto(doctor);
            return dto;
        }

    }
}
