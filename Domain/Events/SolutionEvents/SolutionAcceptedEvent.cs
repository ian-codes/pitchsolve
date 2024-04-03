using Domain.Abstractions;

namespace Domain.Events.SolutionEvents;

public record SolutionAcceptedEvent(Guid SolutionToAcceptGuid) : IDomainEvent;