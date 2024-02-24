using WheelsCatalog.Application.Contracts.Persistence.Repository.Common;

namespace WheelsCatalog.Application.Contracts.Persistence.Repository;

public interface IBrandRepository : IGenericRepository<Domain.BrandAggregate.Brand>
{
    
}