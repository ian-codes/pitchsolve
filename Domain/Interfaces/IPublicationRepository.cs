using Domain.Entities;

namespace Domain.Interfaces;

public interface IPublicationRepository
{
    public Task<bool> CreateNewProblem(Problem newProblem);
}