using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Concrete
{

    public class AdminRepository : IAdminRepository
    {
        private readonly ClinicaContext context;

        public AdminRepository(ClinicaContext context)
        {
            this.context = context;
        }

        public AdminEntity Create(AdminEntity entity)
        {
            var admin = context.Admins.Add(entity).Entity;
            context.SaveChanges();
            return admin;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AdminEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public AdminEntity GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public AdminEntity GetByFirstName(string firstname)
        {
            throw new NotImplementedException();
        }

        public AdminEntity GetById(int id)
        {
            return context.Admins.Include(x => x.User).Include(x => x.User.Role).FirstOrDefault(x => x.Id == id);
        }

        public AdminEntity GetByLastName(string lastname)
        {
            throw new NotImplementedException();
        }

        public AdminEntity GetByMobilePhone(int number)
        {
            throw new NotImplementedException();
        }

        public AdminEntity Update(AdminEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
