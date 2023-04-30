using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;


namespace BusinessLogic.Services.Abstract
{
    public interface ICabinetService : IService<CabinetDto>
    {
        CabinetDto GetByName(string name);
    }
}
