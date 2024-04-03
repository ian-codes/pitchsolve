using Domain.Abstractions;

namespace Domain.Entities;

/// <summary>
/// Freelancer domain entity.
/// Type of a user.
/// Inherits from abstract class <see cref="BaseUser"/>
/// </summary>
public sealed class Freelancer : BaseUser
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
    public Freelancer(Guid guid
        , DateTimeOffset createdAt
        , string firstName
        , string lastName
        , string email
        , string phone) : base(guid, createdAt, firstName, lastName, email, phone)
    {
        
    }
    
    /// <summary>
    /// List of the freelancer's solutions.
    /// </summary>
    public List<Solution> Solutions { get; set; } = new();
}