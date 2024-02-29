using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListDetailsHandler : IRequestHandler<GetCarDtoListDetailsRequest, PaginatedList<RespondCarDtoDetails>>
{
    private readonly ICarRepository _carRepository;
    private readonly ICarPhotoRepository _carPhotoRepository;
    private readonly IPriceHistoryRepository _priceHistoryRepository;
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IMapper _mapper;

    public GetCarDtoListDetailsHandler(IMapper mapper, ICarRepository carRepository, ICarPhotoRepository carPhotoRepository, IPriceHistoryRepository priceHistoryRepository, ICurrencyRepository currencyRepository)
    {
        _mapper = mapper;
        _carRepository = carRepository;
        _carPhotoRepository = carPhotoRepository;
        _priceHistoryRepository = priceHistoryRepository;
        _currencyRepository = currencyRepository;
    }

    public async Task<PaginatedList<RespondCarDtoDetails>> Handle(GetCarDtoListDetailsRequest request, CancellationToken cancellationToken)
    {
        var carFilteringParameters = request.CarFilteringParameters;
        var pageSize = carFilteringParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = carFilteringParameters?.Page ?? Constants.DefaultPageNumber;
        
        var carEntities = await _carRepository.GetAllByFilterAsync(
            pageNumber, 
            pageSize, 
            request.CarFilteringParameters,
            request.PriceFilteringParameters,
            cancellationToken);
        
        var cars = new List<RespondCarDtoDetails>();

        var actualPriceDate = request.PriceFilteringParameters?.Date?.Date ?? DateTime.Today.Date;
        foreach (var car in carEntities)
        {
            var respond = _mapper.Map<RespondCarDtoDetails>(car);
            respond.ModelName = await _carRepository.GetCarModelNameAsync(car.ModelId.Value, cancellationToken) ?? string.Empty;
            respond.BrandName = await _carRepository.GetCarBrandNameAsync(car.ModelId.Value, cancellationToken) ?? string.Empty;
            respond.ColorName = await _carRepository.GetCarColorNameAsync(car.ColorId.Value, cancellationToken) ?? string.Empty;

            var photos = await _carPhotoRepository.GetAllPhotosByCarId(car.Id);
            respond.PhotoUrl = photos.Select(entity => entity.PhotoUrl).ToList();
            
            var price = await _priceHistoryRepository.GetActualPriceByCarIdStartByDateAsync(car.Id.Value, actualPriceDate, cancellationToken);
            respond.Price = _mapper.Map<RespondPriceDto>(price);
            if (price != null) respond.Price.CurrencyAcronym = _currencyRepository.GetCurrencyAcronym(price.CurrencyId) ?? string.Empty;
            
            cars.Add(respond);
        }

        return new PaginatedList<RespondCarDtoDetails>(cars, pageNumber, pageSize);
    }
}