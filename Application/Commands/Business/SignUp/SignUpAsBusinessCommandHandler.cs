using Application.Dtos.Business;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Commands.Business.SignUp;

public sealed class SignUpAsBusinessCommandHandler(IPasswordService passwordService
    , ISender mediator
    , IBusinessRepository businessRepository
    , IPublicationRepository publicationRepository) : IRequestHandler<SignUpAsBusinessCommand, BusinessDto>
{
    public async Task<BusinessDto> Handle(SignUpAsBusinessCommand request, CancellationToken cancellationToken)
    {
        var dto = request.BusinessSignUpDto;
        var hashedPass = passwordService.Hash(dto.Password);
        var businessUserToBeCreated = new BusinessEntity(
            DateTimeOffset.Now
            , dto.FirstName
            , dto.LastName
            , dto.Email
            , dto.PhoneNumber
            , dto.BusinessName
            , dto.BusinessAddress
            );

        var newBusinessUser = await businessRepository.CreateNewBusinessUser(businessUserToBeCreated);
        return BusinessDto.MapFromBusinessEntity(newBusinessUser);
    }
}