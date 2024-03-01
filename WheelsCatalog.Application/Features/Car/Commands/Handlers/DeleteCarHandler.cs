using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class DeleteCarHandler : IRequestHandler<DeleteCarRequest, CarId>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCarHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<CarId> Handle(DeleteCarRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var car = await _unitOfWork.CarRepository.GetByIdAsync(id, cancellationToken);
        if (car == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Car", Id = command.Id!.Value});
        
        await _unitOfWork.CarRepository.DeleteAsync(car, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return car.Id;
    }
}