using Domain.Entities;

namespace Application.Dtos.Business;

public class BusinessDto
{
    private BusinessDto(Guid guid, string firstName, string lastName, string businessName)
    {
        Guid = guid;
        FirstName = firstName;
        LastName = lastName;
        BusinessName = businessName;
    }

    public Guid Guid { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BusinessName { get; set; }
    
    
    public static BusinessDto MapFromBusinessEntity(BusinessEntity business)
    {
        return new BusinessDto(business.Guid, business.FirstName, business.LastName, business.BusinessName);
    }
}