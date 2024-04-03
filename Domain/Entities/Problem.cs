using Domain.Abstractions;
using Domain.Events.ProblemEvents;

namespace Domain.Entities;

/// <summary>
/// Problem published by a business.
/// Inherits from the abstract class <see cref="BasePublication"/>.
/// </summary>
public sealed class Problem : BasePublication
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="isPublished"></param>
    /// <param name="guid"></param>
    /// <param name="authorGuid"></param>
    /// <param name="createdAt"></param>
    /// <param name="title"></param>
    /// <param name="description"></param>
    private Problem(
        Guid authorGuid
        , DateTimeOffset createdAt
        , string title
        , string description
        , bool isPublished = default
        , Guid guid = default
        )
        : base(guid == Guid.Empty ? Guid.NewGuid() : guid, authorGuid, createdAt, title, description)
    {
        IsPublished = isPublished;
    }

    /// <summary>
    /// Factory creation of a problem.
    /// </summary>
    /// <param name="authorGuid"></param>
    /// <param name="title"></param>
    /// <param name="description"></param>
    /// <param name="isPublished"></param>
    /// <returns></returns>
    public static Problem Create(Guid authorGuid, string title, string description, bool isPublished = default)
    {
        var problem = new Problem(authorGuid, DateTimeOffset.Now, title, description, isPublished, Guid.NewGuid());
        problem.RaiseDomainEvent(new ProblemCreatedEvent(problem));
        return problem;
    }

    /// <summary>
    /// Is the problem published (public or private).
    /// </summary>
    public bool IsPublished { get; set; }


    public void Publish()
    {
        IsPublished = true;
        RaiseDomainEvent(new ProblemPublishedEvent(this));
    }

    
    public void Unpublish()
    {
        IsPublished = false;
        RaiseDomainEvent(new ProblemUnpublishedEvent(this));
    }
}