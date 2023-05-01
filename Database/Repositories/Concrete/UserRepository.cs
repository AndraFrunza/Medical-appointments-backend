using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Database.Repositories.Concrete
{
   public class UserRepository : IUserRepository
    {
        private readonly ClinicaContext context;

        public UserRepository(ClinicaContext context)
        {
            this.context = context;
        }

        public UserEntity Create(UserEntity entity)
        {
            var user = context.Users.Add(entity).Entity;
            context.SaveChanges();
            return user;
        }

        public void Delete(int id)
        {
            var user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public List<UserEntity> GetAll()
        {
            return context.Users.ToList();
        }

        public UserEntity GetByEmail(string email)
        {
            return context.Users.FirstOrDefault(x => x.Email == email);
        }

        public UserEntity GetByFirstName(string firstname)
        {
            return context.Users.FirstOrDefault(x => x.FirstName == firstname);
        }

        public UserEntity GetById(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        public UserEntity GetByLastName(string lastname)
        {
            return context.Users.FirstOrDefault(x => x.LastName == lastname);
        }

        public UserEntity GetByPassword(string password)
        {
            return context.Users.FirstOrDefault(x => x.Password == password);
        }

        public UserEntity Update(UserEntity entity)
        {
            var user = context.Users.Update(entity).Entity;
            context.SaveChanges();
            return user;
        }
    }
}
