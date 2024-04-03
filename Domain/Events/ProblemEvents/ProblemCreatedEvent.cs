using Domain.Abstractions;
using Domain.Entities;

namespace Domain.Events.ProblemEvents;

public sealed record ProblemCreatedEvent(Problem NewProblem) : IDomainEvent;