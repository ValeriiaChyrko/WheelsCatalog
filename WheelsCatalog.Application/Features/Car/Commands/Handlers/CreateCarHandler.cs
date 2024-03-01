using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class CreateCarHandler : IRequestHandler<CreateCarRequest, CarId>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateCarHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<CarId> Handle(CreateCarRequest command, CancellationToken cancellationToken)
    {
        var modelId = command.CarDto!.ModelId!.Value;
        var colorId = command.CarDto!.ColorId!.Value;

        var createCarTransaction = await _unitOfWork.BeginTransactionAsync();
        
        var car = Domain.CarAggregate.Car.Create(
            command.CarDto.EngineVolume, 
            command.CarDto.Description, 
            ColorId.Create(colorId), 
            ModelId.Create(modelId)); 
        await _unitOfWork.CarRepository.AddAsync(car, cancellationToken);
        
        await AddPriceAsync(car.Id, command.CarDto.Price!, cancellationToken);
        await _unitOfWork.CommitAsync(createCarTransaction, cancellationToken);

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