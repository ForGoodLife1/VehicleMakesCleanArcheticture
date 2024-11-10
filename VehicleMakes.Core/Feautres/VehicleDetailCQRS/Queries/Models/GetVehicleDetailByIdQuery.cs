using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Responses;

namespace VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Models
{
    public class GetVehicleDetailByIdQuery : IRequest<Response<GetVehicleDetailByIdResponse>>
    {
        public int Id { get; set; }
        public GetVehicleDetailByIdQuery(int id)
        {
            Id = id;
        }
    }

}
