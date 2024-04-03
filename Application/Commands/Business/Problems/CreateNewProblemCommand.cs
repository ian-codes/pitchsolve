using Application.Dtos.Publications.Problem;
using MediatR;

namespace Application.Commands.Business.Problems;

public sealed record CreateNewProblemCommand(ProblemCreateDto ProblemCreateDto) : IRequest<ProblemDto>;