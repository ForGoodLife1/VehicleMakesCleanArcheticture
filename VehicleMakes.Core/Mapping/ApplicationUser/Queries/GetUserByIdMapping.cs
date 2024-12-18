﻿using VehicleMakes.Core.Features.ApplicationUser.Queries.Results;
using VehicleMakes.Data.Entities.Identity;

namespace VehicleMakes.Core.Mapping.ApplicationUser
{
    public partial class VehicleDetailProfile
    {
        public void GetUserByIdMapping()
        {
            CreateMap<User, GetUserByIdResponse>();
        }
    }
}
