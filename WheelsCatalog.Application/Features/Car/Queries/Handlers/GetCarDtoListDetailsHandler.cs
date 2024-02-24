using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
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
        var carEntities = await _carRepository.ListAsync(cancellationToken);
        var cars = new List<RespondCarDtoDetails>();
        
        foreach (var car in carEntities)
        {
            var respond = _mapper.Map<RespondCarDtoDetails>(car);
            respond.ModelName = await _carRepository.GetCarModelNameAsync(car.ModelId, cancellationToken) ?? throw new InvalidOperationException();
            respond.ColorName = await _carRepository.GetCarColorNameAsync(car.ColorId, cancellationToken) ?? throw new InvalidOperationException();

            var photos = await _carPhotoRepository.GetAllPhotosByCarIdName(car.Id);
            respond.PhotoUrl = photos.Select(entity => entity.PhotoUrl).ToList();
            
            var price = await _priceHistoryRepository.GetActualPriceByCarIdAsync(car.Id, cancellationToken);
            respond.Price = _mapper.Map<RespondPriceDto>(price);
            if (price != null) respond.Price.CurrencyAcronym = _currencyRepository.GetCurrencyAcronym(price.CurrencyId) ??
                                                               throw new InvalidOperationException();
            
            cars.Add(respond);
        }

        var pageSize = request.PaginationParameters?.Limit ?? cars.Count();
        var currentPage = request.PaginationParameters?.Page ?? 1;
        var totalItems = await _carRepository.CountAsync(cancellationToken);

        return new PaginatedList<RespondCarDtoDetails>(cars, pageSize, currentPage, totalItems);
    }
}