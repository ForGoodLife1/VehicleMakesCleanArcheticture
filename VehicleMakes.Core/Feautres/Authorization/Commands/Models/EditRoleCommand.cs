using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Data.Requests;

namespace VehicleMakes.Core.Features.Authorization.Commands.Models
{
    public class EditRoleCommand : EditRoleRequest, IRequest<Response<string>>
    {

    }
}
