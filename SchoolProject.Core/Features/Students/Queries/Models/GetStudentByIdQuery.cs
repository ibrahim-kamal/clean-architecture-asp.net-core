﻿
using MediatR;
using SchoolProject.Core.Base;
using SchoolProject.Core.Features.Students.Queries.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentByIdQuery : IRequest<Response<GetStudentByIdResponse>>
    {
        public int Id { get; set; }
        public GetStudentByIdQuery(int _id)
        {
            Id = _id;
        }

    }
}
