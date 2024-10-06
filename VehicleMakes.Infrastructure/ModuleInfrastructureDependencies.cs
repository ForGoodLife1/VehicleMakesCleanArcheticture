using Microsoft.Extensions.DependencyInjection;
using VehicleMakes.Infrastructure.Abstract;
using VehicleMakes.Infrastructure.InfrastructureBases;
using VehicleMakes.Infrastructure.Repositories;
using VehicleMakes.Infrustructure.Abstracts;
using VehicleMakes.Infrustructure.Repositories;

namespace VehicleMakes.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IBodyRepository, BodyRepository>();
            services.AddTransient<IVehicleDetailRepository, VehicleDetailRepository>();
            services.AddTransient<IDriveTypeRepository, DriveTypeRepository>();
            services.AddTransient<IFuelTypeRepository, FuelTypeRepository>();
            services.AddTransient<IMakeModelRepository, MakeModelRepository>();
            services.AddTransient<IMakeRepository, MakeRepository>();
            services.AddTransient<ISubModelRepository, SubModelRepository>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            return services;
        }
    }
}
