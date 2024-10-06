/*

using VehicleMakes.Core.Feautres.MakeCQRS.Queries.ResponseQueries;

namespace VehicleMakes.Core.Mapping.Makes
{
    public partial class MakeProfile
    {
        public void GetMakeListMapping()
        {
            CreateMap<DriveType, GetMakeListResponse>()
                    .ForMember(dest => dest.MakeModelName2, opt => opt.MapFrom(src => src.MakeModel.ModelName));
        }
    }
}
*/