using FluentValidation;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Infrastructure.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Validations
{
    public class addStudentValidator : AbstractValidator<addStudentCommand>
    {
        private readonly IStudentService _studentservice;
        public addStudentValidator(IStudentService studentservice)
        {
            _studentservice = studentservice;
            applyValidatoionRules();
            applyCustomValidatoionRules();
        }


        public void applyValidatoionRules() {
            RuleFor(st => st.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);


        }



        public void applyCustomValidatoionRules()
        {
            RuleFor(st => st.Name)
                .MustAsync(async (key, CancellationToken) => !(await _studentservice.IsExisteStudentAysnc(key)))
                .WithMessage("Name is Exist");

        }
    }
}

