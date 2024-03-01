using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Handlers;

public class CreatePriceHandler : IRequestHandler<CreatePriceRequest, PriceHistoryId>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreatePriceHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<PriceHistoryId> Handle(CreatePriceRequest command, CancellationToken cancellationToken)
    {
        var currencyId = command.PriceDto!.CurrencyId!.Value;
        var carId = command.PriceDto!.CarId!.Value;
        var date = command.PriceDto.Date!.Value;
        
        var price = Domain.PriceHistoryAggregate.PriceHistory.Create(command.PriceDto!.Amount, date, CurrencyId.Create(currencyId), CarId.Create(carId)); 
        await _unitOfWork.PriceHistoryRepository.AddAsync(price, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return price.Id;
    }
}