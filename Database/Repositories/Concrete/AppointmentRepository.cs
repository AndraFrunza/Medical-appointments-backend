using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
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
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).Include(x => x.Doctor.User.Role).Include(x => x.Patient.User.Role).ToList();
        }

        public AppointmentEntity GetByDateOfBirth(DateTime date)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).FirstOrDefault(x => x.DateOfBirth == date);
        }

        public List<AppointmentEntity> GetByDoctorId(int doctorId)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).Include(x => x.Doctor.User.Role).Include(x => x.Patient.User.Role).Where(x => x.Doctor.Id == doctorId).ToList();
        }

        public AppointmentEntity GetByEmailAdress(string email)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).FirstOrDefault(x => x.EmailAdress == email);
        }

        public AppointmentEntity GetByHeight(int height)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).FirstOrDefault(x => x.Height == height);
        }

        public AppointmentEntity GetByHour(int hour)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).FirstOrDefault(x => x.Hour == hour);
        }

        public AppointmentEntity GetById(int id)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).FirstOrDefault(x => x.Id == id);
        }

        public AppointmentEntity GetByMobilePhone(string number)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).FirstOrDefault(x => x.MobilePhone == number);
        }

        public AppointmentEntity GetBySymptom(string symptom)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).FirstOrDefault(x => x.Symptom == symptom);
        }

        public AppointmentEntity GetByWeight(double weight)
        {
            return context.Appointments.Include(x => x.Doctor).Include(x => x.Patient).Include(x => x.Doctor.User).Include(x => x.Doctor.Cabinet).Include(x => x.Patient.User).FirstOrDefault(x => x.Weight == weight);
        }

        public AppointmentEntity Update(AppointmentEntity entity)
        {
            var appointment = context.Appointments.Update(entity).Entity;
            context.SaveChanges();
            return appointment;
        }
    }
}
