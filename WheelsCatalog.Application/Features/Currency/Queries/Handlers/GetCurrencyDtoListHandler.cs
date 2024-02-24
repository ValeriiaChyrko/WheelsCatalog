﻿using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Currency.Queries.Requests;

namespace WheelsCatalog.Application.Features.Currency.Queries.Handlers;

public class GetCurrencyDtoListHandler : IRequestHandler<GetCurrencyDtoListRequest, PaginatedList<RespondCurrencyDto>>
{
    private readonly ICurrencyRepository _repository;
    private readonly IMapper _mapper;

    public GetCurrencyDtoListHandler(ICurrencyRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondCurrencyDto>> Handle(GetCurrencyDtoListRequest request, CancellationToken cancellationToken)
    {
        var totalItems = await _repository.CountAsync(cancellationToken);
        var pageSize = request.PaginationParameters?.Limit == 0 ? totalItems : request.PaginationParameters!.Limit;
        var pageNumber = request.PaginationParameters?.Page == 0 ? 1 : request.PaginationParameters!.Page;
        
        var currencies = await _repository.ListAsync(pageNumber, pageSize, cancellationToken);
        var respondCurrencyDtos = _mapper.Map<List<RespondCurrencyDto>>(currencies);

        return new PaginatedList<RespondCurrencyDto>(respondCurrencyDtos, pageSize, pageNumber, totalItems);
    }
}