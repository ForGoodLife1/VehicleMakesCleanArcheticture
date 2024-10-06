using Microsoft.EntityFrameworkCore;
using VehicleMakes.Data.Entities.Identity;
using VehicleMakes.Infrastructure;
using VehicleMakes.Infrastructure.InfrastructureBases;
using VehicleMakes.Infrustructure.Abstracts;

namespace VehicleMakes.Infrustructure.Repositories
{
    public class RefreshTokenRepository : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenRepository
    {
        #region Fields
        private DbSet<UserRefreshToken> userRefreshToken;
        #endregion

        #region Constructors
        public RefreshTokenRepository(VehicleMakesDbContext dbContext) : base(dbContext)
        {
            userRefreshToken=dbContext.Set<UserRefreshToken>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
