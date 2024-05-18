using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Validations
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {

        private readonly IStudentService _studentService;

        public EditStudentValidator(IStudentService studentService)
        {
            _studentService = studentService;
            addValidationRules();
            addCustomValidationRules();
        }

        public void addValidationRules()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

            RuleFor(s => s.Phone)
                .Length(11)
                .Matches("^01[0-2,5]{1}[0-9]{8}$").WithMessage("Phone must be 01XXXXXXXXX");
        }


        public void addCustomValidationRules()
        {
            RuleFor(x => x.Name)
                .MustAsync(async (Model, key, CancellationToken) =>
                    !(await _studentService.IsExistStudentForAnotherAysnc(Model.id, key))
                 ).WithMessage("Name Exist");

        }

    }
}
