using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Core.Behaviors;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Repositories;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class ModulesCoreDependencies
    {


        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            //configuration if Mediator
            services.AddMediatR(cfg =>    
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())
            );
            // configuration of Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());





            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));


            return services;
        }

    }
}