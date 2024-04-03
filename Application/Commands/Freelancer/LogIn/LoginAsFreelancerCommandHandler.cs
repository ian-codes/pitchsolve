using Application.Dtos.Freelancer;
using MediatR;

namespace Application.Commands.Freelancer.LogIn;

public class LoginAsFreelancerCommandHandler : IRequestHandler<LoginAsFreelancerCommand, FreelancerDto>
{
    public Task<FreelancerDto> Handle(LoginAsFreelancerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}