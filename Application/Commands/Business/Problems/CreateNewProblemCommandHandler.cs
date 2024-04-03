using Application.Dtos.Publications.Problem;
using MediatR;

namespace Application.Commands.Business.Problems;

public class CreateNewProblemCommandHandler : IRequestHandler<CreateNewProblemCommand, ProblemDto>
{
    public Task<ProblemDto> Handle(CreateNewProblemCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}