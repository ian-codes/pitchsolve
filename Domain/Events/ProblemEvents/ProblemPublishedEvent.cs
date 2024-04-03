using Domain.Abstractions;
using Domain.Entities;
using MediatR;

namespace Domain.Events.ProblemEvents;

public sealed record ProblemPublishedEvent(Problem Problem) : IDomainEvent;