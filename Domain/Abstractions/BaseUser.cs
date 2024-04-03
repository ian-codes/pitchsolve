namespace Domain.Abstractions;

/// <summary>
/// Abstract user class. Implementation is either a freelancer or a business.
/// Any other future user types will all inherit from this class, too.
/// Inherits from base domain entity class <see cref="Entity"/>.
/// </summary>
public abstract class BaseUser : Entity
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
    protected BaseUser(Guid guid
        , DateTimeOffset createdAt
        , string firstName
        , string lastName
        , string email
        , string phone) : base(guid, createdAt)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
    }
    
    /// <summary>
    /// First name of the person.
    /// </summary>
    public string FirstName { get; protected set; }
    
    /// <summary>
    /// Last name of the person.
    /// </summary>
    public string LastName { get; protected set; }
    
    /// <summary>
    /// E-mail address of the person.
    /// </summary>
    public string Email { get; protected set; }
    
    /// <summary>
    /// Phone number of the person.
    /// </summary>
    public string Phone { get; protected set; }
}