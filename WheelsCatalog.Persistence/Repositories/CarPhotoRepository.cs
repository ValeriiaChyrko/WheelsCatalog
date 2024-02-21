using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories.common;

namespace WheelsCatalog.Persistence.Repositories;

internal class CarPhotoRepository : GenericRepository<CarPhotoEntity, CarPhotoEntityModel>, ICarPhotoRepository
{
    private readonly WheelsCatalogDbContext _context;
    private readonly IMapper _mapper;
    
    public CarPhotoRepository(WheelsCatalogDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<CarPhotoEntity>> GetAllPhotosByCarIdName(CarId carId)
    {
        var photos = await _context.Set<CarPhotoEntityModel>()
            .Where(photo => photo.CarId == carId.Value)
            .ToListAsync();

        return photos.Any() ? _mapper.Map<List<CarPhotoEntity>>(photos) : new List<CarPhotoEntity>();
    }
}