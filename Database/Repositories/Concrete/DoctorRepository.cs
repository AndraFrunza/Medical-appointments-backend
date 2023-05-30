using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Database.Repositories.Concrete
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ClinicaContext context;

        public DoctorRepository(ClinicaContext context)
        {
            this.context = context;
        }

        public DoctorEntity Create(DoctorEntity entity)
        {
            var doctor = context.Doctors.Add(entity).Entity;
            context.SaveChanges();
            return doctor;
        }

        public void Delete(int id)
        {
            var doctor = context.Doctors.Find(id);
            if (doctor != null)
            {
                context.Doctors.Remove(doctor);
                context.SaveChanges();
            }
        }

        public List<DoctorEntity> GetAll()
        {
            return context.Doctors.Include(x => x.User).Include(x => x.Cabinet).Include(x => x.User.Role).ToList();
        }

        public List<DoctorEntity> GetByCabinetId(int cabinet)
        {
            return context.Doctors.Include(x => x.Cabinet).Include(x => x.User).Include(x => x.User.Role).Where(x => x.Cabinet.Id == cabinet).ToList();
        }

        public DoctorEntity GetByEmail(string email)
        {
            return context.Doctors.FirstOrDefault(x => x.Email == email);
        }

        public DoctorEntity GetByFirstName(string firstname)
        {
            return context.Doctors.FirstOrDefault(x => x.FirstName == firstname);
        }

        public DoctorEntity GetById(int id)
        {
            return context.Doctors.Include(x => x.Cabinet).Include(x => x.User).Include(x => x.User.Role).FirstOrDefault(x => x.Id == id);
        }

        public DoctorEntity GetByLastName(string lastname)
        {
            return context.Doctors.FirstOrDefault(x => x.LastName == lastname);
        }

        public DoctorEntity GetByMobilePhone(string number)
        {
            return context.Doctors.FirstOrDefault(x => x.MobilePhone == number);
        }

        public DoctorEntity GetBySpecialization(string specialization)
        {
            return context.Doctors.FirstOrDefault(x => x.Specialization == specialization);
        }

        public DoctorEntity GetDoctorByUserId(int userId)
        {
            return context.Doctors.Include(x => x.Cabinet).Include(x => x.User).Include(x => x.User.Role).FirstOrDefault(x => x.User.Id == userId);
        }

        public DoctorEntity Update(DoctorEntity entity)
        {
            var doctor = context.Doctors.Update(entity).Entity;
            context.SaveChanges();
            return doctor;
        }
    }
}
