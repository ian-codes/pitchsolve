using Domain.Abstractions;
using MediatR;

namespace Domain.Events.ProblemEvents;

public record ProblemDeletedEvent(Guid ProblemToDeleteGuid) : IDomainEvent;