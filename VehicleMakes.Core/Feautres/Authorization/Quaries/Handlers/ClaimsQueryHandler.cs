using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using VehicleMakes.Core.Bases;
using VehicleMakes.Core.Features.Authorization.Quaries.Models;
using VehicleMakes.Core.Resources;
using VehicleMakes.Data.Entities.Identity;
using VehicleMakes.Data.Results;
using VehicleMakes.Service.Abstracts;

namespace VehicleMakes.Core.Features.Authorization.Quaries.Handlers
{
    public class ClaimsQueryHandler : ResponseHandler,
        IRequestHandler<ManageUserClaimsQuery, Response<ManageUserClaimsResult>>
    {
        #region Fileds
        private readonly IAuthorizationService _authorizationService;
        private readonly UserManager<User> _userManager;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        #endregion
        #region Constructors
        public ClaimsQueryHandler(IStringLocalizer<SharedResources> stringLocalizer,
                                  IAuthorizationService authorizationService,
                                  UserManager<User> userManager) : base(stringLocalizer)
        {
            _authorizationService = authorizationService;
            _userManager = userManager;
            _stringLocalizer = stringLocalizer;
        }
        #endregion
        #region Handle Functions
        public async Task<Response<ManageUserClaimsResult>> Handle(ManageUserClaimsQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            if (user==null) return NotFound<ManageUserClaimsResult>(_stringLocalizer[SharedResourcesKeys.UserIsNotFound]);
            var result = await _authorizationService.ManageUserClaimData(user);
            return Success(result);
        }
        #endregion
    }
}
