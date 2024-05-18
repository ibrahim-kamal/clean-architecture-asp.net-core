
using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProjet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolProjet.Data.AppMetaData.routes;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;
        #endregion
        #region Constructors
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        #endregion
        #region Functions


        public async Task<List<Student>> GetStudentsAysnc()
        {
            return await _studentRepository.GetStudentsAysnc();
        }
        public async Task<Student> GetStudentByIdAysnc(int id)
        {
            var _Student =  _studentRepository.GetTableNoTracking()
                    .Include(x => x.Department)
                    .Where(x => x.StudID.Equals(id))
                    .FirstOrDefault();

            return _Student;
                
        }

        public async Task<string> addStudentAysnc(Student _student)
        {
            await _studentRepository.AddAsync(_student);
            return "Success";

        }

        public async Task<bool> IsExisteStudentAysnc(string name)
        {
            var studentResult = _studentRepository.GetTableNoTracking()
                .Where(s => s.Name == name)
                .FirstOrDefault();
            if (studentResult == null) return false;

            return true;
        }

        public async Task<string> EditStudentAysnc(Student _student)
        {
            await _studentRepository.UpdateAsync(_student);
            return "Success";
        }

        public async Task<bool> IsExistStudentForAnotherAysnc(int id, string name)
        {

            var studentResult = await _studentRepository.GetTableNoTracking().Where(st => st.StudID != id && st.Name == name).FirstOrDefaultAsync();
            
            if (studentResult == null) return false;
            
            return true;

        }
        #endregion
    }
}
