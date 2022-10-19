﻿// <auto-generated />
using System;
using Labb2_API_Angular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb2_API_Angular.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb2_API_Angular.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Management"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Human Resources"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Marketing and Sales"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentName = "Finance"
                        });
                });

            modelBuilder.Entity("Labb2_API_Angular.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = new Guid("f3d59cdb-a2e3-4b8c-87b4-010604593e1a"),
                            Address = "Kungsgatan 1",
                            DepartmentId = 1,
                            Email = "pretty_princess10@gmail.com",
                            FirstName = "Yasmin",
                            Gender = "Female",
                            LastName = "Larian",
                            PersonalNumber = "9708191229",
                            PhoneNumber = "0751231234",
                            Salary = 34000
                        },
                        new
                        {
                            EmployeeId = new Guid("074a61d9-4bb5-4601-9cbe-3a9050fabe36"),
                            Address = "Riksbyvägen 43",
                            DepartmentId = 2,
                            Email = "bunny_boo@gmail.com",
                            FirstName = "Sasha",
                            Gender = "Female",
                            LastName = "Mason",
                            PersonalNumber = "9610217483",
                            PhoneNumber = "0735890521",
                            Salary = 34200
                        },
                        new
                        {
                            EmployeeId = new Guid("7e7e4179-b1c7-4e2b-b81e-1ba87745b7de"),
                            Address = "Drottninggatan 6b",
                            DepartmentId = 3,
                            Email = "angel85@gmail.com",
                            FirstName = "Cloe",
                            Gender = "Female",
                            LastName = "Santon",
                            PersonalNumber = "9702235461",
                            PhoneNumber = "0709876543",
                            Salary = 33700
                        },
                        new
                        {
                            EmployeeId = new Guid("0a980a8b-8c20-4be1-843b-a6647bf6e110"),
                            Address = "Storgatan 32a",
                            DepartmentId = 4,
                            Email = "koolkat4@gmail.com",
                            FirstName = "Jade",
                            Gender = "Female",
                            LastName = "Hunter",
                            PersonalNumber = "9607111829",
                            PhoneNumber = "0721228563",
                            Salary = 33200
                        });
                });

            modelBuilder.Entity("Labb2_API_Angular.Models.Employee", b =>
                {
                    b.HasOne("Labb2_API_Angular.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}