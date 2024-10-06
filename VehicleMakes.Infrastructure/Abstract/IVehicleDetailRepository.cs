using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Abstract
{
    public interface IVehicleDetailRepository : IGenericRepositoryAsync<VehicleDetail>
    {


        public Task<List<VehicleDetail>> GetVehicleDetailsListAsync();
    }
}
