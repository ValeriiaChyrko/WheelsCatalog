using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Handlers;

public class GetMaxPriceHandler : IRequestHandler<GetMaxPriceRequest, RespondPriceDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetMaxPriceHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<RespondPriceDto> Handle(GetMaxPriceRequest request, CancellationToken cancellationToken)
    {
        var maxPrice = await _unitOfWork.PriceHistoryRepository.GetMaxPriceStartByDateAsync(request.Date!.Value, cancellationToken);
        if (maxPrice == null) return new RespondPriceDto();
        
        var respond = _mapper.Map<RespondPriceDto>(maxPrice);
        respond.CurrencyAcronym = _unitOfWork.CurrencyRepository.GetCurrencyAcronym(maxPrice.CurrencyId) ?? string.Empty;

        return respond;
    }

}