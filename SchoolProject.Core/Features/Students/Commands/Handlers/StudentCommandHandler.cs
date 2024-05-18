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
                                   ,IRequestHandler<EditStudentCommand, Response<string>>
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

            if (_result == "Success") return Created<string>("Added Successfully");

            return BadRequest<string>();




        }

        public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAysnc(request.id);
            if (student == null) return NotFound<string>();
            var studentmapper = _mapper.Map<Student>(request);
            await _studentService.EditStudentAysnc(studentmapper);
            return Created<string>("Edit Successfully");


        }
        #endregion
    }
}
