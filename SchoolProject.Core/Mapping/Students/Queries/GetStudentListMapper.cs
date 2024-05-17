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
    public partial class studentMapper
    {
        public void GetStudentListMapper()
        {
            CreateMap<Student, GetStudentListResponse>()
                .ForMember(dest => dest.DepartmentName, dest => dest.MapFrom(source => source.Department.DName));
        }
    }
}
