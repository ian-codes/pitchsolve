using Domain.Abstractions;

namespace Domain.Events.ProblemEvents;

public record ProblemDeletedEvent(Guid ProblemToDeleteGuid) : IDomainEvent;