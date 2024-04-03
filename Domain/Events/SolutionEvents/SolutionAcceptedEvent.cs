using Domain.Abstractions;
using MediatR;

namespace Domain.Events.SolutionEvents;

public record SolutionAcceptedEvent(Guid SolutionToAcceptGuid) : IDomainEvent;