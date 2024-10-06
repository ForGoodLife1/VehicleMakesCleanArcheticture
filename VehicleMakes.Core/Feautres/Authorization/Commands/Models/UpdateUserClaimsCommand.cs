using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Data.Requests;

namespace VehicleMakes.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserClaimsCommand : UpdateUserClaimsRequest, IRequest<Response<string>>
    {
    }
}
