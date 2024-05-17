using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.BaseInfrastructure;
using SchoolProject.Infrastructure.Repositories;

namespace SchoolProject.Infrastructure
{
    public static class ModulesInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services) {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}