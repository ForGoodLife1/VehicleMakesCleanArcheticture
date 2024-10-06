using VehicleMakes.Core.Features.Authorization.Quaries.Results;
using VehicleMakes.Data.Entities.Identity;

namespace VehicleMakes.Core.Mapping.Roles
{
    public partial class RoleProfile
    {
        public void GetRoleByIdMapping()
        {
            CreateMap<Role, GetRoleByIdResult>();
        }
    }
}
