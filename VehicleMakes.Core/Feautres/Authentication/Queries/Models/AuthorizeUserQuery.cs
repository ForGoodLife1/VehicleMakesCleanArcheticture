using MediatR;
using VehicleMakes.Core.Bases;

namespace VehicleMakes.Core.Features.Authentication.Queries.Models
{
    public class AuthorizeUserQuery : IRequest<Response<string>>
    {
        public string AccessToken { get; set; }
    }
}
