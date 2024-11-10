using MediatR;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Responses;
using VehicleMakes.Core.Wrappers;
using VehicleMakes.Data.Enums;

namespace VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Models
{
    public class GetListPaginatedVehicleDetailQuery : IRequest<PaginatedResult<GetListPaginatedVehicleDetailResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public VehicleDetailOrderingEnum OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
