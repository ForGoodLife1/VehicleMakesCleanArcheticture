﻿using MediatR;
using VehicleMakes.Core.Bases;

namespace VehicleMakes.Core.Features.Authentication.Queries.Models
{
    public class ConfirmEmailQuery : IRequest<Response<string>>
    {
        public int UserId { get; set; }
        public string Code { get; set; }
    }
}
