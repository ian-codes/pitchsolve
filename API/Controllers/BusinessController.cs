using Application.Commands.Business.Login;
using Application.Commands.Business.Problems;
using Application.Commands.Business.SignUp;
using Application.Dtos;
using Application.Dtos.Business;
using Application.Dtos.Publications.Problem;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[ApiController]
[Route("[controller]")]
public sealed class BusinessController(ISender mediator) : ControllerBase
{
    public async Task<ActionResult<BusinessDto>> SignUp([FromBody] BusinessSignUpDto businessSignUpDto)
    {
        return await mediator.Send(new SignUpAsBusinessCommand(businessSignUpDto));
    }

    
    public async Task<ActionResult<BusinessDto>> LogIn([FromBody] LoginDto loginDto)
    {
        return await mediator.Send(new LoginAsBusinessCommand(loginDto));
    }


    public async Task<ActionResult<IEnumerable<ProblemDto>>> GetAllProblems()
    {
        throw new NotImplementedException();
    }
    
    
    public async Task<ActionResult<ProblemDto>> CreateProblem([FromBody] ProblemCreateDto newProblem)
    {
        return await mediator.Send(new CreateNewProblemCommand(newProblem));
    }
    
    
    public async Task<ActionResult<ProblemDto>> EditProblem([FromBody] ProblemEditDto problemToEdit)
    {
        throw new NotImplementedException();
    }
    
    
    public async Task<ActionResult<bool>> PublishProblem([FromBody] Guid problemToPublishGuid)
    {
        throw new NotImplementedException();
    }


    public async Task<ActionResult<bool>> UnpublishProblem([FromBody] Guid problemToUnpublishGuid)
    {
        throw new NotImplementedException();
    }

    
    public async Task<ActionResult<bool>> DeleteProblem([FromBody] Guid problemToDeleteGuid)
    {
        throw new NotImplementedException();
    }
}