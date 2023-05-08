using BusinessLogic.Dtos;
using Database.Entities;
using System.Collections.Generic;
using System.Linq;


namespace BusinessLogic.Mapper
{
   public static class CabinetMapper
    {
        public static CabinetEntity ToEntity(CabinetDto dto)
        {
            return new CabinetEntity 
            { 
                Id = dto.Id,
                Name = dto.Name
            };
        }

        public static CabinetDto ToDto(CabinetEntity entity)
        {
            
            return new CabinetDto 
            { 
                Id = entity.Id, 
                Name = entity.Name,    
            };
        }
    }
}
