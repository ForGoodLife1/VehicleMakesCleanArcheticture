using AutoMapper;

namespace VehicleMakes.Core.Mapping.VehicleDetailMapping
{
    public partial class VehicleDetailProfile : Profile
    {
        public VehicleDetailProfile()
        {
            AddVehicleDetailMapping();
            GetVehicleDetailPaginationMapping();
            GetVehicleDetailByIdMapping();
            GetListVehicleDetailMapping();
            UpdateVehicleDetailMapping();
        }
    }
}
