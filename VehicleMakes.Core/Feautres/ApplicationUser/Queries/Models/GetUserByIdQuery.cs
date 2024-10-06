using MediatR;
using VehicleMakes.Core.Bases;
using VehicleMakes.Core.Features.ApplicationUser.Queries.Results;

namespace VehicleMakes.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserByIdQuery : IRequest<Response<GetUserByIdResponse>>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
