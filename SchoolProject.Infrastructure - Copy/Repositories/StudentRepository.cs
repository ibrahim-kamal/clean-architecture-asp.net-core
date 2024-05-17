using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.BaseInfrastructure;
using SchoolProject.Infrastructure.Data;
using SchoolProjet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student> ,IStudentRepository 
    {
        #region Fields
        #endregion
        #region Constructors
        public StudentRepository(ApplicationDBContext dBContext) : base(dBContext) { }
        #endregion
        #region Functions
        public async Task<List<Student>> GetStudentsAysnc()
        {
            Console.WriteLine("GetStudentsAysnc");
            var students = await _dbContext.Students.Include(s => s.Department).ToListAsync();
            return students;
        }


        #endregion
    }
}
