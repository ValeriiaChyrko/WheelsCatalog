using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class UpdateCarHandler : IRequestHandler<UpdateCarRequest, CarId>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateCarHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<CarId> Handle(UpdateCarRequest command, CancellationToken cancellationToken)
    {
        var car = await _unitOfWork.CarRepository.GetByIdAsync(command.Id!.Value, cancellationToken);
        if (car == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Car", Id = command.Id!.Value});
        
        var modelId = command.CarDto!.ModelId!.Value;
        var colorId = command.CarDto!.ColorId!.Value;
        
        var updateCarTransaction = await _unitOfWork.BeginTransactionAsync();
        
        car.Update(command.CarDto.EngineVolume, command.CarDto.Description, ColorId.Create(colorId), ModelId.Create(modelId));
        await _unitOfWork.CarRepository.UpdateAsync(car, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await AddPriceAsync(car.Id, command.CarDto.Price!, cancellationToken);
        await _unitOfWork.CommitAsync(updateCarTransaction, cancellationToken);
        
        return car.Id;
    }
    
    private async Task AddPriceAsync(CarId carId, RequestPriceDto priceDto, CancellationToken cancellationToken)
    {
        var date = priceDto.Date!.Value;
        var currencyId = priceDto.CurrencyId!.Value;
    
        var price = Domain.PriceHistoryAggregate.PriceHistory.Create(priceDto.Amount, date, CurrencyId.Create(currencyId), carId);
        await _unitOfWork.PriceHistoryRepository.AddAsync(price, cancellationToken);
    }
}