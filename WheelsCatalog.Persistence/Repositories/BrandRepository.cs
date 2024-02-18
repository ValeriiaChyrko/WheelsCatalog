using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

public class BrandRepository : GenericRepository<Brand, BrandEntityModel>, IBrandRepository
{
    public BrandRepository(WheelsCatalogDbContext context, IEntityMapper<Brand, BrandEntityModel> mapper) : base(context, mapper)
    {
    }
    
}