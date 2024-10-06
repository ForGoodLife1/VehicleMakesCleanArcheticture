using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Core.Features.Authorization.Quaries.Results;

namespace VehicleMakes.Core.Features.Authorization.Quaries.Models
{
    public class GetRoleByIdQuery : IRequest<Response<GetRoleByIdResult>>
    {
        public int Id { get; set; }
    }
}
