using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Abstract
{
    public interface IMakeRepository : IGenericRepositoryAsync<Make>
    {


        public Task<List<Make>> GetStudentsListAsync();
    }
}
