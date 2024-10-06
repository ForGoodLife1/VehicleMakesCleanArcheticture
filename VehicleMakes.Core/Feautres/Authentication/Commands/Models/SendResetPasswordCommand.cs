using MediatR;
using VehicleMakes.Core.Bases;

namespace VehicleMakes.Core.Features.Authentication.Commands.Models
{
    public class SendResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
    }
}
