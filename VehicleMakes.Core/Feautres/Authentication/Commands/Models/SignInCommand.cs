
using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Data.Results;

namespace VehicleMakes.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResult>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
