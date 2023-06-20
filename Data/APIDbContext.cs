using Appoiment_API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Appoiment_API.Data
{
    public class APIDbContext : DbContext
    {

        public APIDbContext(DbContextOptions option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    Id = 1,
                    Ci = 0991234567,
                    Name = "William",
                    SurName = "Shakespeare",
                    Email = "W.Shake@gmail.com",
                    Password = "password",
                    Age = 30,
                    Role_id = 3,
                }
            );
            modelBuilder.Entity<Med>().HasData(
                new Med
                {
                    Id = 1,
                    Ci = 0994749304,
                    Name = "Frank",
                    SurName = "Campos",
                    Email = "F.Campos@gmail.com",
                    Password = "password",
                    Speciality_id = 1,
                    Role_id = 2,
                }
            );
            modelBuilder.Entity<Admin>().HasData(
               new Admin
               {
                   Id = 1,
                   Ci = 0934985782,
                   Name = "Carlos",
                   SurName = "Celeste",
                   Email = "C.Celeste@gmail.com",
                   Password = "password",
                   Role_id = 1,
               }
           );
           modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   Id = 1,
                   Name = "Admin"
               },
               new Admin
               {
                   Id = 2,
                   Name = "Med"
               },
               new Admin
               {
                   Id = 3,
                   Name = "Patient"
               }
           );
           modelBuilder.Entity<Speciality>().HasData(
                new Speciality
                {
                    Id = 1,
                    Name = "Alergologia",
                    Consult_cost = 40,
                },
                new Speciality
                {
                    Id = 2,
                    Name = "Cardiologia",
                    Consult_cost = 60,
                },
                new Speciality
                {
                    Id = 3,
                    Name = "Cirugia General",
                    Consult_cost = 100,
                },
                new Speciality
                {
                    Id = 4,
                    Name = "Gastroenterologia",
                    Consult_cost = 40,
                },
                new Speciality
                {
                    Id = 5,
                    Name = "Dermatologia",
                    Consult_cost = 50,
                },
                new Speciality
                {
                    Id = 6,
                    Name = "Geriatria",
                    Consult_cost = 40,
                },
                new Speciality
                {
                    Id = 7,
                    Name = "Ginecologia",
                    Consult_cost = 40,
                },
                new Speciality
                {
                    Id = 8,
                    Name = "Medicina General",
                    Consult_cost = 20,
                }
           );
           modelBuilder.Entity<Appoiment>().HasData(
                new Appoiment
                {
                    Id = 1,
                    Patient_id = 1,
                    Med_id = 1,
                    Date_id = 1,
                    Speciality_id = 2,
                    Cost = 60,
                }
           );
            modelBuilder.Entity<Date>().HasData(
                new Date
                {
                    Id = 1,
                    Date_Appoiment = DateTime.Now,
                   
                }
           );
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Med> Meds { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appoiment> Appoiments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Speciality> Specialities { get; set; }


    }
}
