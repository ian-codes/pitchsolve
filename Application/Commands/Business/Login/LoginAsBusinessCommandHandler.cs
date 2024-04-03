using Application.Dtos.Business;
using MediatR;

namespace Application.Commands.Business.Login;

public class LoginAsBusinessCommandHandler : IRequestHandler<LoginAsBusinessCommand, BusinessDto>
{
    public Task<BusinessDto> Handle(LoginAsBusinessCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}