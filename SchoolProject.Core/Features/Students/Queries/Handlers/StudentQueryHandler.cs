using AutoMapper;
using MediatR;
using SchoolProject.Core.Base;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProjet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler,
                                       IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>,
                                       IRequestHandler<GetStudentByIdQuery, Response<GetStudentByIdResponse>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region constructors
        public StudentQueryHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentService.GetStudentsAysnc();
            var studentsMapper = _mapper.Map<List<GetStudentListResponse>>(students);
            return Success(studentsMapper);
        }

        public async Task<Response<GetStudentByIdResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAysnc(request.Id);
            if (student is null) return NotFound<GetStudentByIdResponse>();
            var studentMapper = _mapper.Map<GetStudentByIdResponse>(student);
            return Success(studentMapper);
        }
    }
}
