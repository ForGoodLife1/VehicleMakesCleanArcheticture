using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Data.Results;

namespace VehicleMakes.Core.Features.Authentication.Commands.Models
{
    public class RefreshTokenCommand : IRequest<Response<JwtAuthResult>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
