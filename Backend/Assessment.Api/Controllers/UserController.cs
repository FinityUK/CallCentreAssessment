using Assessment.Application.Calls.Queries;
using Assessment.Application.Users.Commands;
using Assessment.Application.Users.Queries;

namespace Assessment.Api.Controllers;

public class UserController(IMediator mediator) : BaseApiController
{
    [HttpGet]
    public async Task<PaginatedResult<GetPaginatedUsersQueryRow>> GetPaginatedUsersAsync(
        [FromQuery] GetPaginatedUsersQuery query) =>
        await mediator.Send(query);
    
    [HttpGet("list")]
    public async Task<Result<GetUsersListResult>> GetUsersListAsync(
        [FromQuery] GetUsersListQuery query) =>
        await mediator.Send(query);
    
    [HttpPost]
    public async Task<Result<CreateUserResult>> CreateUserAsync(
        [FromBody] CreateUserCommand command) =>
        await mediator.Send(command);
}