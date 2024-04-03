using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Business;

public class BusinessSignUpDto
{
    public BusinessSignUpDto(string businessName
        , string businessAddress
        , string firstName
        , string lastName
        , string position
        , string email
        , string phoneNumber
        , string password)
    {
        BusinessName = businessName;
        BusinessAddress = businessAddress;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Email = email;
        PhoneNumber = phoneNumber;
        Password = password;
    }

    [MinLength(3)]
    public string BusinessName { get; set; }
    
    [MinLength(8)]
    public string BusinessAddress { get; set; }

    
    [MinLength(3)]
    public string FirstName { get; set; }
    
    [MinLength(3)]
    public string LastName { get; set; }
    
    [MinLength(3)]
    public string Position { get; set; }

    
    [EmailAddress]
    public string Email { get; set; }
    
    [Phone]
    public string PhoneNumber { get; set; }

    [MinLength(8)]
    [PasswordPropertyText]
    public string Password { get; set; }
}