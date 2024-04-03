using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Endpoints;

[ApiController]
[Route("[controller]")]
public sealed class UserController(ISender mediator) : ControllerBase
{

}