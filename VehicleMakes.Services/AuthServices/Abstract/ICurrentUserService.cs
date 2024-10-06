using VehicleMakes.Data.Entities.Identity;

namespace VehicleMakes.Service.AuthServices.Abstract
{
    public interface ICurrentUserService
    {
        public Task<User> GetUserAsync();
        public int GetUserId();
        public Task<List<string>> GetCurrentUserRolesAsync();
    }
}
