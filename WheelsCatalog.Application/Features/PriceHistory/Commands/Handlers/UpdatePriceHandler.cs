using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Handlers;

public class UpdatePriceHandler : IRequestHandler<UpdatePriceRequest, PriceHistoryId>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdatePriceHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<PriceHistoryId> Handle(UpdatePriceRequest command, CancellationToken cancellationToken)
    {
        var price = await _unitOfWork.PriceHistoryRepository.GetByIdAsync(command.Id!.Value, cancellationToken);
        if (price == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Price", Id = command.Id.Value});
        
        var currencyId = command.PriceDto!.CurrencyId!.Value;
        var carId = command.PriceDto!.CarId!.Value;
        var date = command.PriceDto.Date!.Value;
        price.Update(command.PriceDto!.Amount, date, CurrencyId.Create(currencyId), CarId.Create(carId));
        await _unitOfWork.PriceHistoryRepository.UpdateAsync(price, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return price.Id;
    }
}