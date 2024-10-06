﻿using MediatR;
using VehicleMakes.Core.Features.ApplicationUser.Queries.Results;
using VehicleMakes.Core.Wrappers;

namespace VehicleMakes.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserPaginationReponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
