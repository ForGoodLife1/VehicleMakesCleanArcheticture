using AutoMapper;

namespace VehicleMakes.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            AddUserMapping();
            GetUserPaginationMapping();
            GetUserByIdMapping();
            UpdateUserMapping();
        }
    }
}
