using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Handlers;

public class GetMinPriceHandler : IRequestHandler<GetMinPriceRequest, RespondPriceDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetMinPriceHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<RespondPriceDto> Handle(GetMinPriceRequest request, CancellationToken cancellationToken)
    {
        var minPrice = await _unitOfWork.PriceHistoryRepository.GetMinPriceStartByDateAsync(request.Date!.Value, cancellationToken);
        if (minPrice == null) return new RespondPriceDto();
        
        var respond = _mapper.Map<RespondPriceDto>(minPrice);
        respond.CurrencyAcronym = _unitOfWork.CurrencyRepository.GetCurrencyAcronym(minPrice.CurrencyId) ?? string.Empty;

        return respond;
    }

}