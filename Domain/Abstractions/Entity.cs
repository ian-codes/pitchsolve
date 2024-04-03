namespace Domain.Abstractions;

/// <summary>
/// Domain entity base abstract base class. All domain entities inherit from this class.
/// </summary>
public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = [];

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="guid"></param>
    /// <param name="createdAt"></param>
    protected Entity(Guid guid, DateTimeOffset createdAt)
    {
        Guid = guid;
        CreatedAt = createdAt;
    }

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
    
    
    /// <summary>
    /// Globally unique identifier of the entity.
    /// </summary>
    public Guid Guid { get; protected set; }
    
    /// <summary>
    /// Date and time of creation of the entity.
    /// </summary>
    public DateTimeOffset CreatedAt { get; protected set; }
}