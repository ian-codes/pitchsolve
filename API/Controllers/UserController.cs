using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class UserController(ISender mediator) : ControllerBase
{

}