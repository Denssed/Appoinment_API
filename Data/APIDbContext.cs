using Appoiment_API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
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
                    Name = "Jeremy",
                    SurName = "Rodriguez",
                    Email = "rodriguezp.jeremy@gmail.com",
                    Password = "5s12JolyfpPW/omcfJAnfQ==",
                    Age = 30,
                    Speciality_id = 0,
                    Role = "patient"
                }, new User
                {
                    Id = 2,
                    Ci = 0994749304,
                    Name = "Frank",
                    SurName = "Campos",
                    Email = "F.Campos@gmail.com",
                    Password = "5s12JolyfpPW/omcfJAnfQ==",
                    Speciality_id = 1,
                    Age = 30,
                    Role = "med"
                },
                 new User
                 {
                     Id = 3,
                     Ci = 0934985782,
                     Name = "Carlos",
                     SurName = "Celeste",
                     Email = "C.Celeste@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 1,
                     Age = 30,
                     Role = "admin"
                 }, new User
                 {
                     Id = 4,
                     Ci = 0934985785,
                     Name = "Sebastion",
                     SurName = "Ramos",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 2,
                     Age = 30,
                     Role = "patient"
                 }, new User
                 {
                     Id = 5,
                     Ci = 0934985785,
                     Name = "Alex",
                     SurName = "Ramos",
                     Email = "A.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 2,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 6,
                     Ci = 0934985785,
                     Name = "Marcelo",
                     SurName = "Collantes",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 3,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 7,
                     Ci = 0934985785,
                     Name = "Felix",
                     SurName = "Mesa",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 4,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 8,
                     Ci = 0934985785,
                     Name = "Paul",
                     SurName = "Saltos",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 5,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 9,
                     Ci = 0934985785,
                     Name = "Ariana",
                     SurName = "Uga",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 6,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 10,
                     Ci = 0934985785,
                     Name = "Melisa",
                     SurName = "Campusano",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 7,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 11,
                     Ci = 0934985785,
                     Name = "Homero",
                     SurName = "Salguero",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 1,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 12,
                     Ci = 0934985785,
                     Name = "Susana",
                     SurName = "Mesa",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 1,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 13,
                     Ci = 0934985785,
                     Name = "Francisco",
                     SurName = "Comarca",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 1,
                     Age = 30,
                     Role = "med"
                 }, new User
                 {
                     Id = 14,
                     Ci = 0934985785,
                     Name = "Favio",
                     SurName = "Flor",
                     Email = "S.Ramos@gmail.com",
                     Password = "5s12JolyfpPW/omcfJAnfQ==",
                     Speciality_id = 1,
                     Age = 30,
                     Role = "med"
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
                    Med_id = 2,
                    Date_timeStamp = 1689001200,
                    Speciality_id = 2,
                    Cost = 60,
                },
                new Appoiment
                {
                    Id = 2,
                    Patient_id = 1,
                    Med_id = 2,
                    Date_timeStamp = 1689001300,
                    Speciality_id = 2,
                    Cost = 70,
                },
                new Appoiment
                {
                    Id = 3,
                    Patient_id = 1,
                    Med_id = 2,
                    Date_timeStamp = 1689001300,
                    Speciality_id = 2,
                    Cost = 80,
                },
                new Appoiment
                {
                    Id = 4,
                    Patient_id = 4,
                    Med_id = 2,
                    Date_timeStamp = 1689001300,
                    Speciality_id = 2,
                    Cost = 60,
                },
                new Appoiment
                {
                    Id = 5,
                    Patient_id = 4,
                    Med_id = 2,
                    Date_timeStamp = 1689001300,
                    Speciality_id = 2,
                    Cost = 600,
                },
                new Appoiment
                {
                    Id = 6,
                    Patient_id = 4,
                    Med_id = 2,
                    Date_timeStamp = 1689001300,
                    Speciality_id = 2,
                    Cost = 10,
                }
           );
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Appoiment> Appoiments { get; set; }
        public DbSet<Speciality> Specialities { get; set; }


    }
}
