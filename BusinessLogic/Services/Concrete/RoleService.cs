using BusinessLogic.Dtos;
using BusinessLogic.Mapper;
using BusinessLogic.Services.Interfaces;
using Database.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository repository;

        public RoleService(IRoleRepository repository)
        {
            this.repository = repository;
        }

        public RoleDto Create(RoleDto dto)
        {
            var entity = RoleMapper.ToEntity(dto);
            entity = repository.Create(entity);
            dto = RoleMapper.ToDto(entity);
            return dto;
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<RoleDto> GetAll()
        {
            var entities = repository.GetAll();
            var dtos = new List<RoleDto>();
            foreach(var entity in entities)
            {
                dtos.Add(RoleMapper.ToDto(entity));
            }
            return dtos;
        }

        public RoleDto GetById(int id)
        {
            var entity = repository.GetById(id);
            if(entity == null)
            {
                return null;
            }
            var dto = RoleMapper.ToDto(entity);
            return dto;
        }

        public RoleDto GetByName(string name)
        {
            var entity = repository.GetByName(name);
            var dto = RoleMapper.ToDto(entity);
            return dto;
        }

        public RoleDto Update(RoleDto dto)
        {
            var entity = RoleMapper.ToEntity(dto);
            entity = repository.Update(entity);
            dto = RoleMapper.ToDto(entity);
            return dto;
        }
    }
}
