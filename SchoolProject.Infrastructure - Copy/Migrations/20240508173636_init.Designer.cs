﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolProject.Infrastructure.Data;

#nullable disable

namespace SchoolProject.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240508173636_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolProjet.Data.Entities.Department", b =>
                {
                    b.Property<int>("DID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DID"));

                    b.Property<string>("DName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.DepartmentSubject", b =>
                {
                    b.Property<int>("DeptSubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptSubID"));

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<int>("SubID")
                        .HasColumnType("int");

                    b.HasKey("DeptSubID");

                    b.HasIndex("DeptID");

                    b.HasIndex("SubID");

                    b.ToTable("DepartmentSubjects");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.Student", b =>
                {
                    b.Property<int>("StudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("DID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("StudID");

                    b.HasIndex("DID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.StudentSubject", b =>
                {
                    b.Property<int>("StudSubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudSubID"));

                    b.Property<int>("StudID")
                        .HasColumnType("int");

                    b.Property<int>("SubID")
                        .HasColumnType("int");

                    b.HasKey("StudSubID");

                    b.HasIndex("StudID");

                    b.HasIndex("SubID");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.Subject", b =>
                {
                    b.Property<int>("SubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubID"));

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("SubID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.DepartmentSubject", b =>
                {
                    b.HasOne("SchoolProjet.Data.Entities.Department", "Departments")
                        .WithMany("DepartmentSubjects")
                        .HasForeignKey("DeptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolProjet.Data.Entities.Subject", "Subjects")
                        .WithMany("DepartmentSubjects")
                        .HasForeignKey("SubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.Student", b =>
                {
                    b.HasOne("SchoolProjet.Data.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.StudentSubject", b =>
                {
                    b.HasOne("SchoolProjet.Data.Entities.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolProjet.Data.Entities.Subject", "Subjects")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.Department", b =>
                {
                    b.Navigation("DepartmentSubjects");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("SchoolProjet.Data.Entities.Subject", b =>
                {
                    b.Navigation("DepartmentSubjects");

                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
