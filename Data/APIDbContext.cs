using Appoiment_API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Appoiment_API.Data
{
    public class APIDbContext : DbContext
    {

        public APIDbContext(DbContextOptions option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Ci = 0991234567,
                    Name = "William",
                    SurName = "Shakespeare",
                    Email = "W.Shake@gmail.com",
                    Password = "password",
                    Age = 30,
                    Speciality_id = 0,
                    Role = "patient",
                }
            );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 2,
                    Ci = 0994749304,
                    Name = "Frank",
                    SurName = "Campos",
                    Email = "F.Campos@gmail.com",
                    Password = "password",
                    Speciality_id = 1,
                    Age = 30,
                    Role = "med",
                }
            );
            modelBuilder.Entity<User>().HasData(
               new User
               {
                   Id = 3,
                   Ci = 0934985782,
                   Name = "Carlos",
                   SurName = "Celeste",
                   Email = "C.Celeste@gmail.com",
                   Password = "password",
                   Speciality_id = 0,
                   Age = 30,
                   Role = "admin",
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
                    Date_timeStamp = "1689001200",
                    Speciality_id = 2,
                    Cost = 60,
                }
           );
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Appoiment> Appoiments { get; set; }
        public DbSet<Speciality> Specialities { get; set; }


    }
}
