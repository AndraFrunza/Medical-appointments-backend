using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Database.Context
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {
            
        }

        //tabelele
        public DbSet<AdminEntity> Admins  { get; set; }
        public DbSet<AppointmentEntity> Appointments { get; set; }

        public DbSet<CabinetEntity> Cabinets { get; set; }
        public DbSet<DoctorEntity> Doctors { get; set; }

        public DbSet<PatientEntity> Patients { get; set; }

        public DbSet<RoleEntity> Roles { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<AdminEntity>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<UserEntity>().HasIndex(x => x.Email).IsUnique(); //creaza index ca sa fie email unic
            modelBuilder.Entity<PatientEntity>().HasMany<AppointmentEntity>().WithOne().OnDelete(DeleteBehavior.Cascade); //daca sterg pacientul , se sterge si programarea
            modelBuilder.Entity<DoctorEntity>().HasMany<AppointmentEntity>().WithOne().OnDelete(DeleteBehavior.NoAction);
            var roles = new List<RoleEntity>();

            foreach(var role in Enum.GetValues(typeof(RoleCodes)).Cast<RoleCodes>().Select(r => (r.ToString(), (int)r)).ToList())
            {
                roles.Add(new RoleEntity() { Id = role.Item2, Name = role.Item1 });
            }

            modelBuilder.Entity<RoleEntity>().HasData(roles);
        }

    }
}
