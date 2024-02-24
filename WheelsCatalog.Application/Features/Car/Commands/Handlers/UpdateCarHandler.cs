using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class UpdateCarHandler : IRequestHandler<UpdateCarRequest, CarId>
{
    private readonly ICarRepository _repository;

    public UpdateCarHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<CarId> Handle(UpdateCarRequest command, CancellationToken cancellationToken)
    {
        var car = await _repository.GetByIdAsync(command.Id!.Value, cancellationToken);
        if (car == null) throw new NotFoundRequestException(command.Id!.Value);
        
        var modelId = command.CarDto!.ModelId!.Value;
        var colorId = command.CarDto!.ColorId!.Value;
        
        car.Update(command.CarDto.EngineVolume, command.CarDto.Description, ColorId.Create(colorId), ModelId.Create(modelId));
        await _repository.UpdateAsync(car, cancellationToken);

        return car.Id;
    }
}