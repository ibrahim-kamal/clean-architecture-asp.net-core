using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Repositories;

namespace SchoolProject.Service
{
    public static class ModulesServiceDependencies
    {

        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}