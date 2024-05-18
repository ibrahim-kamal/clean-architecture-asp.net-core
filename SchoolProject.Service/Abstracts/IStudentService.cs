using SchoolProjet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolProjet.Data.AppMetaData.routes;

namespace SchoolProject.Infrastructure.Abstracts
{
    public interface IStudentService
    {
        public  Task<List<Student>> GetStudentsAysnc();
        public  Task<Student> GetStudentByIdAysnc(int id);
        public Task<string> addStudentAysnc(Student _student);
        public Task<string> EditStudentAysnc(Student _student);
        public Task<Boolean> IsExisteStudentAysnc(string name);
        public Task<Boolean> IsExistStudentForAnotherAysnc(int id , string name);
    }
}
