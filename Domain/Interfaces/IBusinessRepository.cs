using Domain.Entities;

namespace Domain.Interfaces;

public interface IBusinessRepository
{
    public Task<BusinessEntity> CreateNewBusinessUser(BusinessEntity newBusinessUser);
}