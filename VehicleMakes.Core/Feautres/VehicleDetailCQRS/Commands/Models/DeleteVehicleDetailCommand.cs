using MediatR;
using VehicleMakes.Core.Bases;

namespace VehicleMakes.Core.Feautres.VehicleDetailCQRS.Commands.Models
{
    public class DeleteVehicleDetailCommand : IRequest<Response<string>>
    {
        public DeleteVehicleDetailCommand(int id)
        {
            Id=id;
        }

        public int Id { get; set; }
    }
}
