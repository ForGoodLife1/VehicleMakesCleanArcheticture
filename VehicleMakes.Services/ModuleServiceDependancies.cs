using Microsoft.Extensions.DependencyInjection;
using VehicleMakes.Service.Abstracts;
using VehicleMakes.Service.AuthServices.Abstract;
using VehicleMakes.Service.AuthServices.Implementations;
using VehicleMakes.Service.Implementations;

namespace VehicleMakes.Services
{
    public static class ModuleServiceDependancies
    {
        public static IServiceCollection AddServiceDependecies(this IServiceCollection services)
        {
            services.AddTransient<IMakeService, MakeService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IEmailsService, EmailsService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();

            services.AddTransient<IFileService, FileService>();
            return services;
        }
    }
}
