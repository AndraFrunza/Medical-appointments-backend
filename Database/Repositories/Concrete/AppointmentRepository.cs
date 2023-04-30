using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Database.Repositories.Concrete
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ClinicaContext context;

        public AppointmentRepository(ClinicaContext context)
        {
            this.context = context;
        }

        public AppointmentEntity Create(AppointmentEntity entity)
        {
            var appointment = context.Appointments.Add(entity).Entity;
            context.SaveChanges();
            return appointment;
        }

        public void Delete(int id)
        {
            var appointment = context.Appointments.Find(id);
            if (appointment != null)
            {
                context.Appointments.Remove(appointment);
                context.SaveChanges();
            }
        }

        public List<AppointmentEntity> GetAll()
        {
            return context.Appointments.ToList();
        }

        public AppointmentEntity GetByDateOfBirth(int date)
        {
            return context.Appointments.FirstOrDefault(x => x.DateOfBirth == date);
        }

        public AppointmentEntity GetByEmailAdress(string email)
        {
            return context.Appointments.FirstOrDefault(x => x.EmailAdress == email);
        }

        public AppointmentEntity GetByHeight(int height)
        {
            return context.Appointments.FirstOrDefault(x => x.Height == height);
        }

        public AppointmentEntity GetByHour(int hour)
        {
            return context.Appointments.FirstOrDefault(x => x.Hour == hour);
        }

        public AppointmentEntity GetById(int id)
        {
            return context.Appointments.FirstOrDefault(x => x.Id == id);
        }

        public AppointmentEntity GetByMobilePhone(int number)
        {
            return context.Appointments.FirstOrDefault(x => x.MobilePhone == number);
        }

        public AppointmentEntity GetBySymptom(string symptom)
        {
            return context.Appointments.FirstOrDefault(x => x.Symptom == symptom);
        }

        public AppointmentEntity GetByWeight(int weight)
        {
            return context.Appointments.FirstOrDefault(x => x.Weight == weight);
        }

        public AppointmentEntity Update(AppointmentEntity entity)
        {
            var appointment = context.Appointments.Update(entity).Entity;
            context.SaveChanges();
            return appointment;
        }
    }
}
