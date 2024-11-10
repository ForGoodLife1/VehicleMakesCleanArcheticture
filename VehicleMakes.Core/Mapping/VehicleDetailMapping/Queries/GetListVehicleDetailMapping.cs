using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Responses;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Core.Mapping.VehicleDetailMapping
{
    public partial class VehicleDetailProfile
    {
        public void GetListVehicleDetailMapping()
        {
            CreateMap<VehicleDetail, GetListVehicleDetailResponse>();
        }
    }
}
