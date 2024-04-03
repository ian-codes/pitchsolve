using Application.Dtos;
using Application.Dtos.Business;
using MediatR;

namespace Application.Commands.Business.Login;

public sealed record LoginAsBusinessCommand(LoginDto LoginDto) : IRequest<BusinessDto>;