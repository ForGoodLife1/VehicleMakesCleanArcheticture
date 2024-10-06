using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Data.Results;

namespace VehicleMakes.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManageUserClaimsResult>>
    {
        public int UserId { get; set; }
    }
}
