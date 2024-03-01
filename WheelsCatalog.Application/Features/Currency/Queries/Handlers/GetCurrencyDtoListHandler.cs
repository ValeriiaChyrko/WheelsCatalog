using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Currency.Queries.Requests;

namespace WheelsCatalog.Application.Features.Currency.Queries.Handlers;

public class GetCurrencyDtoListHandler : IRequestHandler<GetCurrencyDtoListRequest, List<RespondCurrencyDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetCurrencyDtoListHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<RespondCurrencyDto>> Handle(GetCurrencyDtoListRequest request, CancellationToken cancellationToken)
    {
        var currencies = await _unitOfWork.CurrencyRepository.ListAsync(cancellationToken);
        var respondCurrencyDtos = _mapper.Map<List<RespondCurrencyDto>>(currencies);

        return new List<RespondCurrencyDto>(respondCurrencyDtos);
    }
}