using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Handlers;

public class UpdateModelHandler : IRequestHandler<UpdatePriceRequest, PriceHistoryId>
{
    private readonly IPriceHistoryRepository _repository;

    public UpdateModelHandler(IPriceHistoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<PriceHistoryId> Handle(UpdatePriceRequest command, CancellationToken cancellationToken)
    {
        var price = await _repository.GetByIdAsync(command.Id!.Value, cancellationToken);
        if (price == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Price", Id = command.Id.Value});
        
        var currencyId = command.PriceDto!.CurrencyId!.Value;
        var carId = command.PriceDto!.CarId!.Value;
        var date = command.PriceDto.Date!.Value;
        price.Update(command.PriceDto!.Amount, date, CurrencyId.Create(currencyId), CarId.Create(carId));
        await _repository.UpdateAsync(price, cancellationToken);

        return price.Id;
    }
}