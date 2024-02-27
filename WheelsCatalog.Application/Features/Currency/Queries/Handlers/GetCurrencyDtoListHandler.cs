using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Currency.Queries.Requests;

namespace WheelsCatalog.Application.Features.Currency.Queries.Handlers;

public class GetCurrencyDtoListHandler : IRequestHandler<GetCurrencyDtoListRequest, List<RespondCurrencyDto>>
{
    private readonly ICurrencyRepository _repository;
    private readonly IMapper _mapper;

    public GetCurrencyDtoListHandler(ICurrencyRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RespondCurrencyDto>> Handle(GetCurrencyDtoListRequest request, CancellationToken cancellationToken)
    {
        var currencies = await _repository.ListAsync(cancellationToken);
        var respondCurrencyDtos = _mapper.Map<List<RespondCurrencyDto>>(currencies);

        return new List<RespondCurrencyDto>(respondCurrencyDtos);
    }
}