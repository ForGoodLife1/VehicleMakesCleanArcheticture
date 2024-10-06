using Microsoft.EntityFrameworkCore;
using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.Abstract;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Repositories
{
    public class FuelTypeRepository : GenericRepositoryAsync<FuelType>, IFuelTypeRepository
    {
        #region Fields
        private readonly DbSet<FuelType> _fuelType;
        #endregion
        #region Constructors
        public FuelTypeRepository(VehicleMakesDbContext dBContext) : base(dBContext)
        {
            _fuelType = dBContext.Set<FuelType>();
        }

        #endregion


    }
}