using Application.Dtos.Business;
using MediatR;

namespace Application.Commands.Business.SignUp;

public sealed record SignUpAsBusinessCommand(BusinessSignUpDto BusinessSignUpDto) : IRequest<BusinessDto>;