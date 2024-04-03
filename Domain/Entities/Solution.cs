using Domain.Abstractions;

namespace Domain.Entities;

/// <summary>
/// Solution to a problem, created by a freelancer.
/// Inherits from the abstract class <see cref="BasePublication"/>.
/// </summary>
public sealed class Solution : BasePublication
{
    /// <summary>
    /// Globally unique identifier of the problem that the solution was made for.
    /// </summary>
    public Guid ProblemGuid { get; private set; }

    
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="guid"></param>
    /// <param name="authorGuid"></param>
    /// <param name="createdAt"></param>
    /// <param name="title"></param>
    /// <param name="description"></param>
    /// <param name="problemGuid"></param>
    public Solution(Guid guid
        , Guid authorGuid
        , DateTimeOffset createdAt
        , string title
        , string description
        , Guid problemGuid) : base(guid, authorGuid, createdAt, title, description)
    {
        ProblemGuid = problemGuid;
    }
}