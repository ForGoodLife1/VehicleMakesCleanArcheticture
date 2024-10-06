using Microsoft.EntityFrameworkCore;
using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.Abstract;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Repositories
{
    public class MakeModelRepository : GenericRepositoryAsync<MakeModel>, IMakeModelRepository
    {
        #region Fields
        private readonly DbSet<MakeModel> _makeModel;
        #endregion
        #region Constructors
        public MakeModelRepository(VehicleMakesDbContext dBContext) : base(dBContext)
        {
            _makeModel = dBContext.Set<MakeModel>();
        }

        #endregion


    }
}