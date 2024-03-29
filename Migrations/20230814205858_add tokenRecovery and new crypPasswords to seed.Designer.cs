﻿// <auto-generated />
using Appoiment_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Appoiment_API.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20230814205858_add tokenRecovery and new crypPasswords to seed")]
    partial class addtokenRecoveryandnewcrypPasswordstoseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Appoiment_API.Data.Models.Appoiment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<double>("Date_timeStamp")
                        .HasColumnType("float");

                    b.Property<int>("Med_id")
                        .HasColumnType("int");

                    b.Property<int>("Patient_id")
                        .HasColumnType("int");

                    b.Property<int>("Speciality_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Appoiments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 60,
                            Date_timeStamp = 1689001200.0,
                            Med_id = 2,
                            Patient_id = 1,
                            Speciality_id = 2
                        },
                        new
                        {
                            Id = 2,
                            Cost = 70,
                            Date_timeStamp = 1689001300.0,
                            Med_id = 2,
                            Patient_id = 1,
                            Speciality_id = 2
                        },
                        new
                        {
                            Id = 3,
                            Cost = 80,
                            Date_timeStamp = 1689001300.0,
                            Med_id = 2,
                            Patient_id = 1,
                            Speciality_id = 2
                        },
                        new
                        {
                            Id = 4,
                            Cost = 60,
                            Date_timeStamp = 1689001300.0,
                            Med_id = 2,
                            Patient_id = 4,
                            Speciality_id = 2
                        },
                        new
                        {
                            Id = 5,
                            Cost = 600,
                            Date_timeStamp = 1689001300.0,
                            Med_id = 2,
                            Patient_id = 4,
                            Speciality_id = 2
                        },
                        new
                        {
                            Id = 6,
                            Cost = 10,
                            Date_timeStamp = 1689001300.0,
                            Med_id = 2,
                            Patient_id = 4,
                            Speciality_id = 2
                        });
                });

            modelBuilder.Entity("Appoiment_API.Data.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Consult_cost")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Consult_cost = 40,
                            Name = "Alergologia"
                        },
                        new
                        {
                            Id = 2,
                            Consult_cost = 60,
                            Name = "Cardiologia"
                        },
                        new
                        {
                            Id = 3,
                            Consult_cost = 100,
                            Name = "Cirugia General"
                        },
                        new
                        {
                            Id = 4,
                            Consult_cost = 40,
                            Name = "Gastroenterologia"
                        },
                        new
                        {
                            Id = 5,
                            Consult_cost = 50,
                            Name = "Dermatologia"
                        },
                        new
                        {
                            Id = 6,
                            Consult_cost = 40,
                            Name = "Geriatria"
                        },
                        new
                        {
                            Id = 7,
                            Consult_cost = 40,
                            Name = "Ginecologia"
                        },
                        new
                        {
                            Id = 8,
                            Consult_cost = 20,
                            Name = "Medicina General"
                        });
                });

            modelBuilder.Entity("Appoiment_API.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Ci")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("TokenRecovery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 30,
                            Ci = 991234567,
                            Email = "W.Shake@gmail.com",
                            Name = "William",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "patient",
                            Speciality_id = "0",
                            SurName = "Shakespeare",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 2,
                            Age = 30,
                            Ci = 994749304,
                            Email = "F.Campos@gmail.com",
                            Name = "Frank",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "1",
                            SurName = "Campos",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 3,
                            Age = 30,
                            Ci = 934985782,
                            Email = "C.Celeste@gmail.com",
                            Name = "Carlos",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "admin",
                            Speciality_id = "1",
                            SurName = "Celeste",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 4,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Sebastion",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "patient",
                            Speciality_id = "2",
                            SurName = "Ramos",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 5,
                            Age = 30,
                            Ci = 934985785,
                            Email = "A.Ramos@gmail.com",
                            Name = "Alex",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "2",
                            SurName = "Ramos",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 6,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Marcelo",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "3",
                            SurName = "Collantes",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 7,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Felix",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "4",
                            SurName = "Mesa",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 8,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Paul",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "5",
                            SurName = "Saltos",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 9,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Ariana",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "6",
                            SurName = "Uga",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 10,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Melisa",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "7",
                            SurName = "Campusano",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 11,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Homero",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "1",
                            SurName = "Salguero",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 12,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Susana",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "1",
                            SurName = "Mesa",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 13,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Francisco",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "1",
                            SurName = "Comarca",
                            TokenRecovery = ""
                        },
                        new
                        {
                            Id = 14,
                            Age = 30,
                            Ci = 934985785,
                            Email = "S.Ramos@gmail.com",
                            Name = "Favio",
                            Password = "5s12JolyfpPW/omcfJAnfQ==",
                            Role = "med",
                            Speciality_id = "1",
                            SurName = "Flor",
                            TokenRecovery = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
