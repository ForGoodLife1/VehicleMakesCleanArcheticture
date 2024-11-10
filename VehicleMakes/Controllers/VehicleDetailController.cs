using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VehicleMakes.Api.Base;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Commands.Models;
using VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Models;
using VehicleMakes.Core.Filters;
using VehicleMakes.Data.AppMetaData;

namespace VehicleMakes.Api.Controllers
{
    [ApiController]
    public class VehicleDetailController : AppControllerBase
    {
        [HttpGet(Router.VehicleDetailRouting.List)]
        [Authorize(Roles = "User")]
        [ServiceFilter(typeof(AuthFilter))]
        public async Task<IActionResult> GetVehicleDetailList()
        {
            var response = await Mediator.Send(new GetListVehicleDetailQuery());
            return Ok(response);
        }
        [AllowAnonymous]
        [HttpGet(Router.VehicleDetailRouting.Paginated)]
        public async Task<IActionResult> Paginated([FromQuery] GetListPaginatedVehicleDetailQuery query)
        {
            var response = await Mediator.Send(query);
            return Ok(response);
        }
        [HttpGet(Router.VehicleDetailRouting.GetByID)]
        public async Task<IActionResult> GetVehicleDetailByID([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new GetVehicleDetailByIdQuery(id)));
        }
        [Authorize(Policy = "CreateVehicleDetail")]
        [HttpPost(Router.VehicleDetailRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddVehicleDetailCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [Authorize(Policy = "EditVehicleDetail")]
        [HttpPut(Router.VehicleDetailRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditVehicleDetailCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [Authorize(Policy = "DeleteVehicleDetail")]
        [HttpDelete(Router.VehicleDetailRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteVehicleDetailCommand(id)));
        }
    }
}
