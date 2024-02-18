using WheelsCatalog.Application.contracts.persistence.common;

namespace WheelsCatalog.Application.contracts.persistence;

public interface IBrandRepository : IGenericRepository<Domain.BrandAggregate.Brand>
{
    
}