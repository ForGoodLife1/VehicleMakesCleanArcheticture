using Microsoft.EntityFrameworkCore;
using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.Abstract;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Repositories
{
    public class SubModelRepository : GenericRepositoryAsync<SubModel>, ISubModelRepository
    {
        #region Fields
        private readonly DbSet<SubModel> _subModel;
        #endregion
        #region Constructors
        public SubModelRepository(VehicleMakesDbContext dBContext) : base(dBContext)
        {
            _subModel = dBContext.Set<SubModel>();
        }

        #endregion


    }
}