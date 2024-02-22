using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Handlers;

public class CreatePriceHandler : IRequestHandler<CreatePriceRequest, PriceHistoryId>
{
    private readonly IPriceHistoryRepository _repository;

    public CreatePriceHandler(IPriceHistoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<PriceHistoryId> Handle(CreatePriceRequest command, CancellationToken cancellationToken)
    {
        var currencyId = command.PriceDto!.CurrencyId!.Value;
        var carId = command.PriceDto!.CarId!.Value;
        var date = command.PriceDto.Date!.Value;
        
        var price = Domain.PriceHistoryAggregate.PriceHistory.Create(command.PriceDto!.Amount, date, CurrencyId.Create(currencyId), CarId.Create(carId)); 
        await _repository.AddAsync(price, cancellationToken);

        return price.Id;
    }
}