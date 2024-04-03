using Domain.Abstractions;
using Domain.Entities;

namespace Domain.Events.ProblemEvents;

public sealed record ProblemPublishedEvent(Problem Problem) : IDomainEvent;