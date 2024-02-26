using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

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
        if (car == null) throw new NotFoundRequestException(request.Id!.Value);

        var respond = _mapper.Map<RespondCarDtoDetails>(car);
        respond.ModelName = await _carRepository.GetCarModelNameAsync(car.ModelId.Value, cancellationToken) ?? throw new InvalidOperationException();
        respond.ColorName = await _carRepository.GetCarColorNameAsync(car.ColorId.Value, cancellationToken) ?? throw new InvalidOperationException();
        respond.BrandName = await _carRepository.GetCarBrandNameAsync(car.ModelId.Value, cancellationToken) ?? throw new InvalidOperationException();

        var photos = await _carPhotoRepository.GetAllPhotosByCarId(car.Id);
        respond.PhotoUrl = photos.Select(entity => entity.PhotoUrl).ToList();

        var price = await _priceHistoryRepository.GetActualPriceByCarIdAsync(car.Id.Value, cancellationToken);
        respond.Price = _mapper.Map<RespondPriceDto>(price);
        if (price != null) respond.Price.CurrencyAcronym = _currencyRepository.GetCurrencyAcronym(price.CurrencyId) ??
                                                           throw new InvalidOperationException();

        return respond;
    }
}