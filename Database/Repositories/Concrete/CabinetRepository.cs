using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Database.Repositories.Concrete
{
    class CabinetRepository : ICabinetRepository
    {
        private readonly ClinicaContext context;

        public CabinetRepository(ClinicaContext context)
        {
            this.context = context;
        }

        public CabinetEntity Create(CabinetEntity entity)
        {
            var cabinet = context.Cabinets.Add(entity).Entity;
            context.SaveChanges();
            return cabinet;
        }

        public void Delete(int id)
        {
            var cabinet = context.Cabinets.Find(id);
            if (cabinet != null)
            {
                context.Cabinets.Remove(cabinet);
                context.SaveChanges();
            }
        }

        public List<CabinetEntity> GetAll()
        {
            return context.Cabinets.ToList();
        }

        public CabinetEntity GetById(int id)
        {
            return context.Cabinets.FirstOrDefault(x => x.Id == id);
        }

        public CabinetEntity GetByName(string name)
        {
            return context.Cabinets.FirstOrDefault(x => x.Name == name);
        }

        public CabinetEntity Update(CabinetEntity entity)
        {
            var cabinet = context.Cabinets.Update(entity).Entity;
            context.SaveChanges();
            return cabinet;
        }
    }
}
