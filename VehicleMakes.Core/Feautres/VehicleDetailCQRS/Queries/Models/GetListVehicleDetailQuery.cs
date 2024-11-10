using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Responses;

namespace VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Models
{
    public class GetListVehicleDetailQuery : IRequest<Response<List<GetListVehicleDetailResponse>>>
    {

    }
}
