using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using System.Linq.Expressions;
using VehicleDetails.Services.Abstracts;
using VehicleMakes.Core.Bases;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Models;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Responses;
using VehicleMakes.Core.Resources;
using VehicleMakes.Core.Wrappers;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Handlers
{
    public class VehicleDetailHandlerQuery : ResponseHandler,
                                           IRequestHandler<GetListVehicleDetailQuery, Response<List<GetListVehicleDetailResponse>>>,
                                           IRequestHandler<GetVehicleDetailByIdQuery, Response<GetVehicleDetailByIdResponse>>,
                                           IRequestHandler<GetListPaginatedVehicleDetailQuery, PaginatedResult<GetListPaginatedVehicleDetailResponse>>
    {
        private readonly IVehicleDetailService _vehicleDetailService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public VehicleDetailHandlerQuery(IVehicleDetailService vehicleDetailService, IMapper mapper,
                                         IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _vehicleDetailService=vehicleDetailService;
            _mapper=mapper;
            _localizer=localizer;
        }

        public async Task<Response<List<GetListVehicleDetailResponse>>> Handle(GetListVehicleDetailQuery request, CancellationToken cancellationToken)
        {
            var vehicleDetailList = await _vehicleDetailService.GetVehicleDetailsListAsync();
            var vehicleDetailMapepr = _mapper.Map<List<GetListVehicleDetailResponse>>(vehicleDetailList);
            var result = Success(vehicleDetailMapepr);
            result.Meta= new { cont = vehicleDetailMapepr.Count() };
            return result;
        }

        public async Task<Response<GetVehicleDetailByIdResponse>> Handle(GetVehicleDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var singlevehicleDetail = await _vehicleDetailService.GetByIDAsync(request.Id);
            if (singlevehicleDetail==null) return NotFound<GetVehicleDetailByIdResponse>(_localizer[SharedResourcesKeys.NotFound]);
            var result = _mapper.Map<GetVehicleDetailByIdResponse>(singlevehicleDetail);
            return Success(result);
        }

        public async Task<PaginatedResult<GetListPaginatedVehicleDetailResponse>> Handle(GetListPaginatedVehicleDetailQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<VehicleDetail, GetListPaginatedVehicleDetailResponse>>
                expression = e => new GetListPaginatedVehicleDetailResponse(e.Id, e.MakeId, e.ModelId, e.SubModelId, e.BodyId, e.VehicleDisplayName,
                                                                            e.Year, e.DriveTypeId, e.Engine, e.EngineCc,
                                                                            e.EngineCylinders, e.EngineLiterDisplay, e.FuelTypeId, e.NumDoors);
            var querable = _vehicleDetailService.GetVehicleDetailsQuerable();
            var paginatedList = await querable.Select(expression).ToPaginatedListAsync(request.PageNumber, request.PageSize);
            paginatedList.Meta=new { Count = paginatedList.Data.Count() };
            return paginatedList;

        }
    }
}
