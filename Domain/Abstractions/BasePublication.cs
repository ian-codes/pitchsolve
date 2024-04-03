namespace Domain.Abstractions;

/// <summary>
/// Abstract class of a publication.
/// The implementation can be either a problem (by a business) or a solution (by a freelancer).
/// Inherits from base domain entity class <see cref="Entity"/>.
/// </summary>
public abstract class BasePublication : Entity
{
    /// <summary>
    /// Globally unique identifier of the author (Freelancer or business) of the publication.
    /// </summary>
    public Guid AuthorGuid { get; protected set; }

    /// <summary>
    /// Title of the publication.
    /// </summary>
    public string Title { get; protected set; }
    
    /// <summary>
    /// Description of the publication.
    /// </summary>
    public string Description { get; protected set; }


    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="guid"></param>
    /// <param name="authorGuid"></param>
    /// <param name="createdAt"></param>
    /// <param name="title"></param>
    /// <param name="description"></param>
    protected BasePublication(Guid guid
        , Guid authorGuid
        , DateTimeOffset createdAt
        , string title
        , string description) : base(guid, createdAt)
    {
        Guid = guid;
        AuthorGuid = authorGuid;
        CreatedAt = createdAt;
        Title = title;
        Description = description;
    }
}