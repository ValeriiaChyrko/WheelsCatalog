using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class BrandRepository : GenericRepository<Brand, BrandEntityModel>, IBrandRepository
{
    public BrandRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
}