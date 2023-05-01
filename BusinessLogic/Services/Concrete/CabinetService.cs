using BusinessLogic.Dtos;
using BusinessLogic.Mapper;
using BusinessLogic.Services.Abstract;
using Database.Repositories.Abstract;
using System.Collections.Generic;

namespace BusinessLogic.Services.Concrete
{
    public class CabinetService : ICabinetService
    {
        private readonly ICabinetRepository repository;

        public CabinetService(ICabinetRepository repository)
        {
            this.repository = repository;
        }

        public CabinetDto Create(CabinetDto dto)
        {
            var entity = CabinetMapper.ToEntity(dto);
            entity = repository.Create(entity);
            dto = CabinetMapper.ToDto(entity);
            return dto;
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<CabinetDto> GetAll()
        {
            var entities = repository.GetAll();
            var dtos = new List<CabinetDto>();
            foreach (var entity in entities)
            {
                dtos.Add(CabinetMapper.ToDto(entity));
            }
            return dtos;
        }

        public CabinetDto GetById(int id)
        {
            var entity = repository.GetById(id);
            if (entity == null)
            {
                return null;
            }
            var dto = CabinetMapper.ToDto(entity);
            return dto;
        }

        public CabinetDto GetByName(string name)
        {
            var entity = repository.GetByName(name);
            var dto = CabinetMapper.ToDto(entity);
            return dto;
        }

        public CabinetDto Update(CabinetDto dto)
        {
            var entity = CabinetMapper.ToEntity(dto);
            entity = repository.Update(entity);
            dto = CabinetMapper.ToDto(entity);
            return dto;
        }
    }
}
