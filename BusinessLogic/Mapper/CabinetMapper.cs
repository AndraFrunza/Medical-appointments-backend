using BusinessLogic.Dtos;
using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapper
{
   public static class CabinetMapper
    {
        public static CabinetEntity ToEntity(CabinetDto dto)
        {
            return new CabinetEntity { Id = dto.Id, Name = dto.Name };
        }

        public static CabinetDto ToDto(CabinetEntity dto)
        {
            return new CabinetDto { Id = dto.Id, Name = dto.Name };
        }
    }
}
