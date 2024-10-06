using MediatR;
using VehicleMakes.Core.Bases;

namespace VehicleMakes.Core.Features.Authorization.Commands.Models
{
    public class AddRoleCommand : IRequest<Response<string>>
    {
        public string RoleName { get; set; }
    }
}
