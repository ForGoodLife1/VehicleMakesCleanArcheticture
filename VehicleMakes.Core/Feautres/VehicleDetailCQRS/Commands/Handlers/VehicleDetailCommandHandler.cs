using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using VehicleDetails.Services.Abstracts;
using VehicleMakes.Core.Bases;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Commands.Models;
using VehicleMakes.Core.Resources;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Core.Feautres.VehicleDetailCQRS.Commands.Handlers
{
    public class VehicleDetailCommandHandler : ResponseHandler,
                                               IRequestHandler<AddVehicleDetailCommand, Response<string>>,
                                               IRequestHandler<EditVehicleDetailCommand, Response<string>>,
                                               IRequestHandler<DeleteVehicleDetailCommand, Response<string>>
    {
        private readonly IVehicleDetailService _vehicleDetailService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public VehicleDetailCommandHandler(IVehicleDetailService vehicleDetailService, IMapper mapper,
                                          IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _vehicleDetailService=vehicleDetailService;
            _mapper=mapper;
            _localizer=localizer;
        }

        public async Task<Response<string>> Handle(AddVehicleDetailCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and VehicleDetail
            var VehicleDetailmapper = _mapper.Map<VehicleDetail>(request);
            //add
            var result = await _vehicleDetailService.AddAsync(VehicleDetailmapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(EditVehicleDetailCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var VehicleDetail = await _vehicleDetailService.GetByIDAsync(request.Id);
            //return NotFound
            if (VehicleDetail == null) return NotFound<string>();
            //mapping Between request and VehicleDetail
            var VehicleDetailmapper = _mapper.Map(request, VehicleDetail);
            //Call service that make Edit
            var result = await _vehicleDetailService.EditAsync(VehicleDetailmapper);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);
            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(DeleteVehicleDetailCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var VehicleDetail = await _vehicleDetailService.GetByIDAsync(request.Id);
            //return NotFound
            if (VehicleDetail == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _vehicleDetailService.DeleteAsync(VehicleDetail);
            if (result == "Success") return Deleted<string>();
            else return BadRequest<string>();
        }
    }
}
