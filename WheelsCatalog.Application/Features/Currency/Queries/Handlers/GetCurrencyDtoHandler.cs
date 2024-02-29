using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Currency.Queries.Requests;

namespace WheelsCatalog.Application.Features.Currency.Queries.Handlers;

public class GetCurrencyDtoHandler : IRequestHandler<GetCurrencyDtoRequest, RespondCurrencyDto>
{
    private readonly ICurrencyRepository _repository;
    private readonly IMapper _mapper;

    public GetCurrencyDtoHandler(ICurrencyRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<RespondCurrencyDto> Handle(GetCurrencyDtoRequest request, CancellationToken cancellationToken)
    {
        var currency = await _repository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (currency == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Currency", Id = request.Id!.Value});

        return _mapper.Map<RespondCurrencyDto>(currency);
    }
}