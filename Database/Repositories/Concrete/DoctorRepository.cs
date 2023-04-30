using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
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
            return context.Doctors.ToList();
        }

        public DoctorEntity GetById(int id)
        {
            return context.Doctors.FirstOrDefault(x => x.Id == id);
        }

        public DoctorEntity GetBySpecialization(string specialization)
        {
            return context.Doctors.FirstOrDefault(x => x.Specialization == specialization);
        }

        public DoctorEntity Update(DoctorEntity entity)
        {
            var doctor = context.Doctors.Update(entity).Entity;
            context.SaveChanges();
            return doctor;
        }
    }
}
