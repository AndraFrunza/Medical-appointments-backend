using BusinessLogic.Dtos;
using BusinessLogic.Mapper;
using BusinessLogic.Services.Abstract;
using Database.Repositories.Abstract;
using System.Collections.Generic;

namespace BusinessLogic.Services.Concrete
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository repository;
        private readonly IRoleRepository roleRepository;

        public AdminService(IAdminRepository repository, IRoleRepository roleRepository)
        {
            this.repository = repository;
            this.roleRepository = roleRepository;
        }

        public AdminDto Create(AdminDto dto)
        {
            var role = roleRepository.GetById(dto.RoleId);
            var admin = AdminMapper.ToEntity(dto, role);
            admin = repository.Create(admin);
            dto = AdminMapper.ToDto(admin);
            return dto;
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<AdminDto> GetAll()
        {
            var entities = repository.GetAll();
            var dtos = new List<AdminDto>();
            foreach (var entity in entities)
            {
                dtos.Add(AdminMapper.ToDto(entity));
            }
            return dtos;
        }

        public AdminDto GetByEmail(string email)
        {
            var entity = repository.GetByEmail(email);
            var dto = AdminMapper.ToDto(entity);
            return dto;
        }

        public AdminDto GetByFirstName(string firstname)
        {
            var entity = repository.GetByFirstName(firstname);
            var dto = AdminMapper.ToDto(entity);
            return dto;
        }

        public AdminDto GetById(int id)
        {
            var entity = repository.GetById(id);
            if (entity == null)
            {
                return null;
            }
            var dto = AdminMapper.ToDto(entity);
            return dto;
        }

        public AdminDto GetByLastName(string lastname)
        {
            var entity = repository.GetByLastName(lastname);
            var dto = AdminMapper.ToDto(entity);
            return dto;
        }

        public AdminDto Update(AdminDto dto)
        {
            var role = roleRepository.GetById(dto.RoleId);
            var entity = AdminMapper.ToEntity(dto, role);
            entity = repository.Update(entity);
            dto = AdminMapper.ToDto(entity);
            return dto;
        }
    }
}
