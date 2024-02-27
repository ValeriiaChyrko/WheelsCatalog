using AutoMapper;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Domain.ColorAggregate;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class ColorRepository : GenericRepository<Color, ColorEntityModel>, IColorRepository
{
    public ColorRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}