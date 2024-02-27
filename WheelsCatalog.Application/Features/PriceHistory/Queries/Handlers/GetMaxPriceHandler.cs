using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Handlers;

public class GetMaxPriceHandler : IRequestHandler<GetMaxPriceRequest, RespondPriceDto>
{
    private readonly IPriceHistoryRepository _priceHistoryRepository;
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IMapper _mapper;

    public GetMaxPriceHandler(IPriceHistoryRepository priceHistoryRepository, IMapper mapper, ICurrencyRepository currencyRepository)
    {
        _priceHistoryRepository = priceHistoryRepository;
        _mapper = mapper;
        _currencyRepository = currencyRepository;
    }

    public async Task<RespondPriceDto> Handle(GetMaxPriceRequest request, CancellationToken cancellationToken)
    {
        var maxPrice = await _priceHistoryRepository.GetMaxPriceStartByDateAsync(request.Date!.Value, cancellationToken);
        if (maxPrice == null) return new RespondPriceDto();
        
        var respond = _mapper.Map<RespondPriceDto>(maxPrice);
        respond.CurrencyAcronym = _currencyRepository.GetCurrencyAcronym(maxPrice.CurrencyId) ?? throw new InvalidOperationException();

        return respond;
    }

}