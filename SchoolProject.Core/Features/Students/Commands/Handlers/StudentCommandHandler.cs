using AutoMapper;
using MediatR;
using SchoolProject.Core.Base;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProjet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{
    class StudentCommandHandler : ResponseHandler,
                                    IRequestHandler<addStudentCommand, Response<string>>
    {
        #region constructors
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion
        #region constructors

        public StudentCommandHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion
        #region functions
        public async Task<Response<string>> Handle(addStudentCommand request, CancellationToken cancellationToken)
        {
            var studentmapper = _mapper.Map<Student>(request);
            var _result = await _studentService.addStudentAysnc(studentmapper);

            if (_result == "Exist") return UnprocessableEntity<string>("");
            else if (_result == "Success") return Created<string>("Added Succefully");

            return BadRequest<string>();




        }
        #endregion
    }
}
