﻿using Microsoft.EntityFrameworkCore;
using SchoolProjet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
            
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options) 
        {
            
        }
         
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<DepartmentSubject> DepartmentSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
    }
}
