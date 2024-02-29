using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoDetailsHandler : IRequestHandler<GetCarDtoDetailsRequest, RespondCarDtoDetails>
{
    private readonly ICarRepository _carRepository;
    private readonly ICarPhotoRepository _carPhotoRepository;
    private readonly IPriceHistoryRepository _priceHistoryRepository;
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IMapper _mapper;

    public GetCarDtoDetailsHandler(IMapper mapper, ICarRepository carRepository, ICarPhotoRepository carPhotoRepository, IPriceHistoryRepository priceHistoryRepository, ICurrencyRepository currencyRepository)
    {
        _mapper = mapper;
        _carRepository = carRepository;
        _carPhotoRepository = carPhotoRepository;
        _priceHistoryRepository = priceHistoryRepository;
        _currencyRepository = currencyRepository;
    }

    public async Task<RespondCarDtoDetails> Handle(GetCarDtoDetailsRequest request, CancellationToken cancellationToken)
    {
        var car = await _carRepository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (car == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Car", Id = request.Id!.Value});

        var respond = _mapper.Map<RespondCarDtoDetails>(car);
        respond.ModelName = await _carRepository.GetCarModelNameAsync(car.ModelId.Value, cancellationToken) ?? string.Empty;
        respond.ColorName = await _carRepository.GetCarColorNameAsync(car.ColorId.Value, cancellationToken) ?? string.Empty;
        respond.BrandName = await _carRepository.GetCarBrandNameAsync(car.ModelId.Value, cancellationToken) ?? string.Empty;

        respond.PhotoUrl = await GetCarPhotosAsync(request.Id.Value);
        respond.Price = await GetCarPriceAsync(request.Id.Value, cancellationToken);

        return respond;
    }
    
    private async Task<List<string>> GetCarPhotosAsync(Guid carId)
    {
        var photos = await _carPhotoRepository.GetAllPhotosByCarId(CarId.Create(carId));
        return photos.Select(entity => entity.PhotoUrl).ToList();
    }
    
    private async Task<RespondPriceDto?> GetCarPriceAsync(Guid carId, CancellationToken cancellationToken)
    {
        var price = await _priceHistoryRepository.GetActualPriceByCarIdAsync(carId, cancellationToken);
        if (price == null) return null;
        
        var response = _mapper.Map<RespondPriceDto>(price);
        response.CurrencyAcronym = _currencyRepository.GetCurrencyAcronym(price.CurrencyId) ?? string.Empty;
        return response;
    }
}