using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Handlers;

public class GetMinPriceHandler : IRequestHandler<GetMinPriceRequest, RespondPriceDto>
{
    private readonly IPriceHistoryRepository _priceHistoryRepository;
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IMapper _mapper;

    public GetMinPriceHandler(IPriceHistoryRepository priceHistoryRepository, IMapper mapper, ICurrencyRepository currencyRepository)
    {
        _priceHistoryRepository = priceHistoryRepository;
        _mapper = mapper;
        _currencyRepository = currencyRepository;
    }

    public async Task<RespondPriceDto> Handle(GetMinPriceRequest request, CancellationToken cancellationToken)
    {
        var minPrice = await _priceHistoryRepository.GetMinPriceStartByDateAsync(request.Date!.Value, cancellationToken);
        if (minPrice == null) return new RespondPriceDto();
        
        var respond = _mapper.Map<RespondPriceDto>(minPrice);
        respond.CurrencyAcronym = _currencyRepository.GetCurrencyAcronym(minPrice.CurrencyId) ?? throw new InvalidOperationException();

        return respond;
    }

}