using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Handlers;

public class DeletePriceHandler : IRequestHandler<DeletePriceRequest, PriceHistoryId>
{
    private readonly IPriceHistoryRepository _repository;

    public DeletePriceHandler(IPriceHistoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<PriceHistoryId> Handle(DeletePriceRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var price = await _repository.GetByIdAsync(id, cancellationToken);
        if (price == null) throw new NotFoundRequestException(id);
        
        await _repository.DeleteAsync(price, cancellationToken);
        return price.Id;
    }
}