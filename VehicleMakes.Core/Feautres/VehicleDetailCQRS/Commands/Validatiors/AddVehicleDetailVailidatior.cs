using FluentValidation;
using Microsoft.Extensions.Localization;
using VehicleDetails.Services.Abstracts;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Commands.Models;
using VehicleMakes.Core.Resources;

namespace VehicleMakes.Core.Feautres.VehicleDetailCQRS.Commands.Validatiors
{
    public class AddVehicleDetailVailidatior : AbstractValidator<AddVehicleDetailCommand>
    {
        private readonly IVehicleDetailService _vehicleDetailService;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public AddVehicleDetailVailidatior(IVehicleDetailService vehicleDetailService, IStringLocalizer<SharedResources> localizer)
        {
            _vehicleDetailService=vehicleDetailService;
            _localizer=localizer;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.VehicleDisplayName)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

            RuleFor(x => x.Engine)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

        }
        public void ApplyCustomValidationsRules()
        {



        }
    }
}
