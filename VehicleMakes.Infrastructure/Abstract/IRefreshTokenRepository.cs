using VehicleMakes.Data.Entities.Identity;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrustructure.Abstracts
{
    public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
    {

    }
}
