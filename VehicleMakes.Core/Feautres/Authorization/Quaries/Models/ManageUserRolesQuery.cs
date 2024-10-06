using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Data.Results;

namespace VehicleMakes.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResult>>
    {
        public int UserId { get; set; }
    }
}
