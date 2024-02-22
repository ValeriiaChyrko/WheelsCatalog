﻿using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Handlers;

public class GetActualPriceByCarHandler : IRequestHandler<GetActualPriceByCarRequest, RespondPriceDto>
{
    private readonly IPriceHistoryRepository _priceHistoryRepository;
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IMapper _mapper;

    public GetActualPriceByCarHandler(IPriceHistoryRepository priceHistoryRepository, IMapper mapper, ICurrencyRepository currencyRepository)
    {
        _priceHistoryRepository = priceHistoryRepository;
        _mapper = mapper;
        _currencyRepository = currencyRepository;
    }

    public async Task<RespondPriceDto> Handle(GetActualPriceByCarRequest request, CancellationToken cancellationToken)
    {
        var carId = request.CarId!.Value;
        var priceHistoryByCar = await _priceHistoryRepository.GetActualPriceByCarIdAsync(CarId.Create(carId), cancellationToken);
        if (priceHistoryByCar == null) return new RespondPriceDto();
        
        var respond = _mapper.Map<RespondPriceDto>(priceHistoryByCar);
        respond.CurrencyAcronym = _currencyRepository.GetCurrencyAcronym(priceHistoryByCar.CurrencyId) ?? throw new InvalidOperationException();

        return respond;
    }

}