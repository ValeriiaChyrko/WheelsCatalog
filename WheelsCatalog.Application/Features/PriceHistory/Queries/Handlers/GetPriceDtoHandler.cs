using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.PriceHistory.Queries.Requests;

namespace WheelsCatalog.Application.Features.PriceHistory.Queries.Handlers;

public class GetPriceDtoHandler : IRequestHandler<GetPriceDtoRequest, RespondPriceDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetPriceDtoHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<RespondPriceDto> Handle(GetPriceDtoRequest request, CancellationToken cancellationToken)
    {
        var carId = request.CarId!.Value;
        var startDate = request.Date!.Value;
        var priceHistoryByCar = await _unitOfWork.PriceHistoryRepository.GetActualPriceByCarIdStartByDateAsync(carId, startDate, cancellationToken);
        if (priceHistoryByCar == null) return new RespondPriceDto();
        
        var respond = _mapper.Map<RespondPriceDto>(priceHistoryByCar);
        respond.CurrencyAcronym = _unitOfWork.CurrencyRepository.GetCurrencyAcronym(priceHistoryByCar.CurrencyId) ?? string.Empty;

        return respond;
    }

}