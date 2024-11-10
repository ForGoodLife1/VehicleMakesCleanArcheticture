using Microsoft.Extensions.DependencyInjection;
using VehicleDetails.Services.Abstracts;
using VehicleMakes.Service.Abstracts;
using VehicleMakes.Service.AuthServices.Abstract;
using VehicleMakes.Service.AuthServices.Implementations;
using VehicleMakes.Service.Implementations;
using VehicleMakes.Services.Implementations;

namespace VehicleMakes.Services
{
    public static class ModuleServiceDependancies
    {
        public static IServiceCollection AddServiceDependecies(this IServiceCollection services)
        {
            services.AddTransient<IVehicleDetailService, VehicleDetailService>();
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
