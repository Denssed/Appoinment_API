﻿// <auto-generated />
using System;
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
    [Migration("20230608145739_add-role-speciality")]
    partial class addrolespeciality
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Appoiment_API.Data.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.Property<int>("Role_id")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Appoiment_API.Data.Models.Appoiment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<int>("Especiality_id")
                        .HasColumnType("int");

                    b.Property<int>("Med_id")
                        .HasColumnType("int");

                    b.Property<int>("Patient_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Appoiments");
                });

            modelBuilder.Entity("Appoiment_API.Data.Models.Med", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.Property<int>("Role_id")
                        .HasColumnType("int");

                    b.Property<string>("Speciality_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Meds");
                });

            modelBuilder.Entity("Appoiment_API.Data.Models.Patient", b =>
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

                    b.Property<int>("Role_id")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Appoiment_API.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Appoiment_API.Data.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("consult_cost")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialities");
                });
#pragma warning restore 612, 618
        }
    }
}
