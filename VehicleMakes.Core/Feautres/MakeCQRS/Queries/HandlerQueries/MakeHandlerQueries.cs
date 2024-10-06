/*using AutoMapper;
using MediatR;
using VehicleMakes.Core.Feautres.MakeCQRS.Queries.ModelQueries;
using VehicleMakes.Core.Feautres.MakeCQRS.Queries.ResponseQueries;
using VehicleMakes.Services.IServices;

namespace VehicleMakes.Core.Feautres.MakeCQRS.Queries.HandlerQueries
{
    public class MakeHandlerQueries : IRequestHandler<GetMakeListQueries, List<GetMakeListResponse>>
    {
        private readonly IMakeService _makeService;
        private readonly IMapper _mapper;

        public MakeHandlerQueries(IMakeService makeService, IMapper mapper)
        {
            _makeService=makeService;
            _mapper=mapper;
        }



        public async Task<List<GetMakeListResponse>> Handle(GetMakeListQueries request, CancellationToken cancellationToken)
        {
            var makeList = await _makeService.GetMakesListAsync();
            var makeListMapper = _mapper.Map<List<GetMakeListResponse>>(makeList);
            return makeListMapper;
        }
    }
}
*/