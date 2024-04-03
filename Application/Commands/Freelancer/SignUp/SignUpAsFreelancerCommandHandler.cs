using Application.Dtos.Freelancer;
using MediatR;

namespace Application.Commands.Freelancer.SignUp;

public sealed class SignUpAsFreelancerCommandHandler : IRequestHandler<SignUpAsFreelancerCommand, FreelancerDto>
{
    public Task<FreelancerDto> Handle(SignUpAsFreelancerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}