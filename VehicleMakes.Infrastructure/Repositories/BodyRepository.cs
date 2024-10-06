using Microsoft.EntityFrameworkCore;
using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.Abstract;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Repositories
{
    public class BodyRepository : GenericRepositoryAsync<Body>, IBodyRepository
    {
        #region Fields
        private readonly DbSet<Body> _bodies;
        #endregion
        #region Constructors
        public BodyRepository(VehicleMakesDbContext dBContext) : base(dBContext)
        {
            _bodies = dBContext.Set<Body>();
        }

        #endregion


    }
}