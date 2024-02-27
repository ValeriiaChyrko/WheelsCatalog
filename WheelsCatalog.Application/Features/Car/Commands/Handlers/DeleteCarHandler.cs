using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class DeleteCarHandler : IRequestHandler<DeleteCarRequest, CarId>
{
    private readonly ICarRepository _repository;

    public DeleteCarHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<CarId> Handle(DeleteCarRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var car = await _repository.GetByIdAsync(id, cancellationToken);
        if (car == null) throw new NotFoundRequestException(id);
        
        await _repository.DeleteAsync(car, cancellationToken);
        return car.Id;
    }
}