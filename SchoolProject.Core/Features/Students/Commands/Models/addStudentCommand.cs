using MediatR;
using SchoolProjet.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Core.Base;

namespace SchoolProject.Core.Features.Students.Commands.Models
{
    public class addStudentCommand :IRequest<Response<string>>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public int? DID { get; set; }


    }
}
