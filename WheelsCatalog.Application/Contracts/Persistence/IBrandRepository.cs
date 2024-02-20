using WheelsCatalog.Application.Contracts.Persistence.Common;

namespace WheelsCatalog.Application.Contracts.Persistence;

public interface IBrandRepository : IGenericRepository<Domain.BrandAggregate.Brand>
{
    
}