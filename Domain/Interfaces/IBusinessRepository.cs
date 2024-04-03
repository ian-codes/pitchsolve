using Domain.Entities;

namespace Domain.Interfaces;

public interface IBusinessRepository
{
    public Task<Business> CreateNewBusinessUser(Business newBusinessUser);
}