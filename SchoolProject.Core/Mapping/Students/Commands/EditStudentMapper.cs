using SchoolProject.Core.Features.Students.Commands.Models;
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
        public void EditStudentMapper() {
            CreateMap<EditStudentCommand, Student>()
                .ForMember(dest => dest.StudID , dest => dest.MapFrom(s => s.id));
        }
    }
}
