using BusinessLogic.Dtos;
using Database.Entities;

namespace BusinessLogic.Mapper
{
   public static class PatientMapper
    {
        public static PatientEntity ToEntity(PatientDto dto)
        {
            return new PatientEntity { Id = dto.Id, MobilePhone = dto.MobilePhone };
        }

        public static PatientDto ToDto(PatientEntity dto)
        {
            return new PatientDto { Id = dto.Id, MobilePhone = dto.MobilePhone };
        }
    }
}
