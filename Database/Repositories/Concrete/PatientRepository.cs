﻿using Database.Context;
using Database.Entities;
using Database.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Database.Repositories.Concrete
{
   public class PatientRepository : IPatientRepository
    {
        private readonly ClinicaContext context;
        public PatientRepository(ClinicaContext context)
        {
            this.context = context;
        }

        public PatientEntity Create(PatientEntity entity)
        {
            var patient = context.Patients.Add(entity).Entity;
            context.SaveChanges();
            return patient;
        }

        public void Delete(int id)
        {
            var patient = context.Patients.Find(id);
            if (patient != null)
            {
                context.Patients.Remove(patient);
                context.SaveChanges();
            }
        }

        public List<PatientEntity> GetAll()
        {
            return context.Patients.Include(x => x.User).Include(x => x.User.Role).ToList();
        }

        public PatientEntity GetById(int id)
        {
            return context.Patients.Include(x => x.User).Include(x => x.User.Role).FirstOrDefault(x => x.Id == id);
        }

        public PatientEntity GetByMobilePhone(string number)
        {
            return context.Patients.FirstOrDefault(x => x.MobilePhone == number);
        }

        public PatientEntity GetPatientByUserId(int userId)
        {
            return context.Patients.Include(x => x.User).Include(x => x.User.Role).FirstOrDefault(x => x.User.Id == userId);
        }

        public PatientEntity Update(PatientEntity entity)
        {
            var patient = context.Patients.Update(entity).Entity;
            context.SaveChanges();
            return patient;
        }
    }
}
