using AutoMapper;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProjet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class studentMapper : Profile
    {
        public studentMapper() {
            GetStudentListMapper();
            GetStudentByIdMapper();
            AddStudentMapper();
        }
    }
}
