using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class DeleteCarDtoPhotosHandlers : IRequestHandler<DeleteCarDtoPhotosRequest, CarPhotoId>
{
    private readonly ICarPhotoRepository _repository;

    public DeleteCarDtoPhotosHandlers(ICarPhotoRepository repository)
    {
        _repository = repository;
    }

    public async Task<CarPhotoId> Handle(DeleteCarDtoPhotosRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var photo = await _repository.GetByIdAsync(id, cancellationToken);
        if (photo == null) throw new NotFoundRequestException(id);
        
        await _repository.DeleteAsync(photo, cancellationToken);
        return photo.Id;
    }
}