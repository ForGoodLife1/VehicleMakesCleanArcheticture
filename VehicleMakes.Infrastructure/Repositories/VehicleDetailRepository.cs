using Microsoft.EntityFrameworkCore;
using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.Abstract;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Repositories
{
    public class VehicleDetailRepository : GenericRepositoryAsync<VehicleDetail>, IVehicleDetailRepository
    {
        #region Fields
        private readonly DbSet<VehicleDetail> _vehicleDetail;
        #endregion
        #region Constructors
        public VehicleDetailRepository(VehicleMakesDbContext dBContext) : base(dBContext)
        {
            _vehicleDetail = dBContext.Set<VehicleDetail>();
        }

        public async Task<List<VehicleDetail>> GetVehicleDetailsListAsync()
        {
            return await _vehicleDetail.Include(x => x.Body)
                                 .Include(x => x.DriveType)
                                 .Include(x => x.FuelType)
                                 .Include(x => x.SubModel)
                                 .ToListAsync();
        }

        #endregion


    }
}