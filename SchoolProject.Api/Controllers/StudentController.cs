using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Api.Base;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Infrastructure.Data;
using SchoolProjet.Data.AppMetaData;
using SchoolProjet.Data.Entities;

namespace SchoolProject.Api.Controllers
{
    
    [ApiController]
    public class StudentController : AppControllerBase
    {
        public StudentController(IMediator mediator) : base(mediator)
        {
        }

        #region functions 

        [HttpGet(routes.studentRoute.LIST)]
        public async Task<IActionResult> list()
        {
            var response = await _mediator.Send(new GetStudentListQuery());
            return NewResult(response);
        }


        [HttpGet(routes.studentRoute.profile)]
        public async Task<IActionResult> student([FromRoute] int id)
        {
            var response = await _mediator.Send(new GetStudentByIdQuery(id));
            return NewResult(response);
        }
        [HttpGet(routes.studentRoute.CREATE)]
        public async Task<IActionResult> Create([FromBody] addStudentCommand addStudentCommand)
        {
            var response = await _mediator.Send(addStudentCommand);
            return NewResult(response);
        }





        #endregion



    }
}
