using Assessment.Application.Calls.Commands;
using Assessment.Application.Calls.Queries;

namespace Assessment.Api.Controllers;

public class CallController(IMediator mediator) : BaseApiController
{
    [HttpGet]
    public async Task<PaginatedResult<GetPaginatedCallsQueryRow>> GetPaginatedCallsAsync(
        [FromQuery] GetPaginatedCallsQuery query) =>
        await mediator.Send(query);
    
    [HttpPost]
    public async Task<Result<CreateCallResult>> CreateCallAsync(
        [FromBody] CreateCallCommand command) =>
        await mediator.Send(command);
}