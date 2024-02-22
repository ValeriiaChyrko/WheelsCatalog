using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Handlers;

public class GetMaxPriceHandler : IRequestHandler<GetMaxPriceRequest, RespondPriceDto>
{
    private readonly IPriceHistoryRepository _priceHistoryRepository;
    private readonly ICarRepository _carRepository;
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IMapper _mapper;

    public GetMaxPriceHandler(IPriceHistoryRepository priceHistoryRepository, IMapper mapper, ICurrencyRepository currencyRepository, ICarRepository carRepository)
    {
        _priceHistoryRepository = priceHistoryRepository;
        _mapper = mapper;
        _currencyRepository = currencyRepository;
        _carRepository = carRepository;
    }

    public async Task<RespondPriceDto> Handle(GetMaxPriceRequest request, CancellationToken cancellationToken)
    {
        var cars = await _carRepository.ListAsync(cancellationToken);
        var startDate = request.Date != null ? request.Date!.Value : DateTime.MinValue;
        var actualPrices = new List<Domain.PriceHistoryAggregate.PriceHistory>();
        foreach (var car in cars)
        {
            var priceHistoryByCar = await _priceHistoryRepository.GetActualPriceByCarIdStartByDateAsync(car.Id, startDate, cancellationToken);
            if (priceHistoryByCar != null) actualPrices.Add(priceHistoryByCar);
        }

        if (actualPrices.Count == 0) throw new InvalidOperationException("No actual prices found for any cars.");

        var maxPrice = actualPrices.OrderByDescending(x => x.Price).First();
        var respond = _mapper.Map<RespondPriceDto>(maxPrice);
        respond.CurrencyAcronym = _currencyRepository.GetCurrencyAcronym(maxPrice.CurrencyId) 
                                  ?? throw new InvalidOperationException();

        return respond;
    }

}