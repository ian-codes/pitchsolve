using Domain.Abstractions;
using Domain.Events.ProblemEvents;
using Domain.Events.SolutionEvents;

namespace Domain.Entities;

/// <summary>
/// Business domain entity.
/// Type of a user.
/// Inherits from abstract class <see cref="BaseUser"/>
/// </summary>
public sealed class Business : BaseUser
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="guid"></param>
    /// <param name="createdAt"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="email"></param>
    /// <param name="phone"></param>
    /// <param name="businessName"></param>
    /// <param name="businessAddress"></param>
    public Business(
        DateTimeOffset createdAt
        , string firstName
        , string lastName
        , string email
        , string phone
        , string businessName
        , string businessAddress
        , Guid guid = default
        )
        : base(guid == Guid.Empty ? Guid.NewGuid() : guid, createdAt, firstName, lastName, email, phone)
    {
        CreatedAt = DateTimeOffset.Now;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        BusinessName = businessName;
        BusinessAddress = businessAddress;
    }
    

    /// <summary>
    /// Name of the business.
    /// </summary>
    public string BusinessName { get; private set; }

    /// <summary>
    /// Address of the business.
    /// </summary>
    public string BusinessAddress { get; private set; }

    /// <summary>
    /// List of the business' problems.
    /// </summary>
    private List<Problem> Problems { get; } = [];


    public void CreateNewProblem(string title, string description)
    {
        Problems.Add(Problem.Create(Guid, title, description));
    }


    public void AcceptSolution(Guid acceptedSolutionGuid)
    {
        RaiseDomainEvent(new SolutionAcceptedEvent(acceptedSolutionGuid));
    }
    
    
    public void DeleteProblem(Guid deletedProblemGuid)
    {
        var deletedProblem = Problems.Find(p => p.Guid == deletedProblemGuid);
        if (deletedProblem is null) 
            return;
        
        RaiseDomainEvent(new ProblemDeletedEvent(deletedProblem.Guid));
    }
    
    
    public void PublishProblem(Guid problemGuid)
    {
        Problems.Find(p => p.Guid == problemGuid)?.Publish();
    }

    
    public void UnpublishProblem(Guid problemGuid)
    {
        Problems.Find(p => p.Guid == problemGuid)?.Unpublish();
    }
}