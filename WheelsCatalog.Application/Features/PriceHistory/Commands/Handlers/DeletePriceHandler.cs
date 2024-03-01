using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.PriceHistory.Commands.Requests;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Handlers;

public class DeletePriceHandler : IRequestHandler<DeletePriceRequest, PriceHistoryId>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeletePriceHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<PriceHistoryId> Handle(DeletePriceRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var price = await _unitOfWork.PriceHistoryRepository.GetByIdAsync(id, cancellationToken);
        if (price == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Price", Id = command.Id.Value});
        
        await _unitOfWork.PriceHistoryRepository.DeleteAsync(price, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return price.Id;
    }
}