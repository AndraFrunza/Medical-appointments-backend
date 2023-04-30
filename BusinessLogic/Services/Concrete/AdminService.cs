using BusinessLogic.Dtos;
using BusinessLogic.Mapper;
using BusinessLogic.Services.Abstract;
using Database.Repositories.Abstract;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Services.Concrete
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository repository;

        public AdminService(IAdminRepository repository)
        {
            this.repository = repository;
        }

        public AdminDto Create(AdminDto dto)
        {
            var admin = AdminMapper.ToEntity(dto);
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
            throw new NotImplementedException();
        }

        public AdminDto GetByFirstName(string firstname)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public AdminDto GetByMobilePhone(int number)
        {
            throw new NotImplementedException();
        }

        public AdminDto Update(AdminDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
