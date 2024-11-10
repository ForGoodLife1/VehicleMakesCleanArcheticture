using AutoMapper;

namespace VehicleMakes.Core.Mapping.ApplicationUser
{
    public partial class VehicleDetailProfile : Profile
    {
        public VehicleDetailProfile()
        {
            AddUserMapping();
            GetUserPaginationMapping();
            GetUserByIdMapping();
            UpdateUserMapping();
        }
    }
}
