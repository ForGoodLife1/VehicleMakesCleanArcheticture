using VehicleMakes.Data.Entities.Identity;

namespace VehicleMakes.Service.Abstracts
{
    public interface IApplicationUserService
    {
        public Task<string> AddUserAsync(User user, string password);
    }
}
