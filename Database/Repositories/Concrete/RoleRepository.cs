using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Database.Repositories.Concrete
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ClinicaContext context;

        public RoleRepository(ClinicaContext context)
        {
            this.context = context;
        }

        public RoleEntity Create(RoleEntity entity)
        {
          var role =  context.Roles.Add(entity).Entity;
          context.SaveChanges();
          return role;
        }

        public void Delete(int id)
        {
            var role = context.Roles.Find(id);
            if(role != null)
            {
                context.Roles.Remove(role);
                context.SaveChanges();
            }
        }

        public List<RoleEntity> GetAll()
        {
            return context.Roles.ToList();
        }

        public RoleEntity GetById(int id)
        {
            return context.Roles.FirstOrDefault(x => x.Id == id);
        }

        public RoleEntity GetByName(string name)
        {
            return context.Roles.FirstOrDefault(x => x.Name == name);
        }

        public RoleEntity Update(RoleEntity entity)
        {
            var role =  context.Roles.Update(entity).Entity;
            context.SaveChanges();
            return role;
        }

        
    }
}
