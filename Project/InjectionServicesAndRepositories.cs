using ProjectDomain.Setup.Interfaces;
using ProjectInfrastructure.Setup.Repositories;
using ProjectApplication.Setup.Interfaces;
using ProjectApplication.Setup.Services;
using ProjectApplication.Setup.Dto;
using ProjectApplication.Setup.Validators;
using FluentValidation;
namespace Project
{
    public static class InjectionServicesAndRepositories
    {
        public static void AddServicesAndRepositories(this IServiceCollection  services)
        {
            services.AddScoped<IEntidadRepository, EntidadesRepository>();
            services.AddScoped<IEntidadService, EntidadService>();
            services.AddTransient<IValidator<EntidadDto>, EntidadValidator>();
        }
    }
}
