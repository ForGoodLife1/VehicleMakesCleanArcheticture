using Microsoft.EntityFrameworkCore;
using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.Abstract;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Repositories
{
    public class DriveTypeRepository : GenericRepositoryAsync<DriveType1>, IDriveTypeRepository
    {
        #region Fields
        private readonly DbSet<DriveType1> _driveType;
        #endregion
        #region Constructors
        public DriveTypeRepository(VehicleMakesDbContext dBContext) : base(dBContext)
        {
            _driveType = dBContext.Set<DriveType1>();
        }

        #endregion


    }
}