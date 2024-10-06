using VehicleMakes.Core.Features.ApplicationUser.Commands.Models;
using VehicleMakes.Data.Entities.Identity;

namespace VehicleMakes.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void AddUserMapping()
        {
            CreateMap<AddUserCommand, User>();
        }
    }
}