using Application.Commands.Freelancer.LogIn;
using Application.Commands.Freelancer.SignUp;
using Application.Dtos.Freelancer;
using Application.Dtos.Publications.Solution;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Endpoints;

[ApiController]
[Route("[controller]")]
public sealed class FreelancerController(ISender mediator)
{
    public async Task<ActionResult<FreelancerDto>> SignUp()
    {
        return await mediator.Send(new SignUpAsFreelancerCommand());
    }

    
    public async Task<ActionResult<FreelancerDto>> LogIn()
    {
        return await mediator.Send(new LoginAsFreelancerCommand());
    }


    public async Task<ActionResult<bool>> CreateSolution([FromBody] SolutionCreateDto newSolution)
    {
        throw new NotImplementedException();
    }


    public async Task<ActionResult<bool>> PublishSolution([FromBody] Guid solutionToPublishGuid)
    {
        throw new NotImplementedException();
    }


    public async Task<ActionResult<bool>> DeleteSolution([FromBody] Guid solutionToDeleteGuid)
    {
        throw new NotImplementedException();
    }
}