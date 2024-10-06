/*using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using VehicleMakes.Api.Base;
using static VehicleMakes.Data.AppMetaData.Router;

namespace VehicleMakes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : AppControllerBase
    {
        [HttpGet(MakeRouting.List)]
        public async Task<IActionResult> GetMakeList()
        {
            var response = await Mediator.Send(new GetMakeListQuery());
            return Ok(response);
        }
        [AllowAnonymous]
        [HttpGet(Router.MakeRouting.Paginated)]
        public async Task<IActionResult> Paginated([FromQuery] GetMakePaginatedListQuery query)
        {
            var response = await Mediator.Send(query);
            return Ok(response);
        }
        [HttpGet(Router.MakeRouting.GetByID)]
        public async Task<IActionResult> GetMakeByID([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new GetMakeByIDQuery(id)));
        }
        //[Authorize(Policy = "CreateMake")]
        [HttpPost(Router.MakeRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddMakeCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [Authorize(Policy = "EditMake")]
        [HttpPut(Router.MakeRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditMakeCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [Authorize(Policy = "DeleteMake")]
        [HttpDelete(Router.MakeRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteMakeCommand(id)));
        }
    }
}
*/