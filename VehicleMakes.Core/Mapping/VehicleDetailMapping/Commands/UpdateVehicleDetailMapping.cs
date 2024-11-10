using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Commands.Models;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Core.Mapping.VehicleDetailMapping
{
    public partial class VehicleDetailProfile
    {
        public void UpdateVehicleDetailMapping()
        {
            CreateMap<EditVehicleDetailCommand, VehicleDetail>();
        }
    }
}
