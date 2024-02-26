using MediatR;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class CreateCarDtoPhotosHandler : IRequestHandler<CreateCarDtoPhotosRequest, CarPhotoId>
{
    private readonly ICarPhotoRepository _repository;
    private readonly IFileService _fileService;

    public CreateCarDtoPhotosHandler(ICarPhotoRepository repository, IFileService fileService)
    {
        _repository = repository;
        _fileService = fileService;
    }

    public async Task<CarPhotoId> Handle(CreateCarDtoPhotosRequest command, CancellationToken cancellationToken)
    {
        var photoUrl = await UploadLogoAsync(command.Photo!);
        if (photoUrl == null) throw new OperationCanceledException("Failed to upload photo.");
        
        var carId = command.CarId!.Value;
        var photo = Domain.CarAggregate.Entities.CarPhotoEntity.Create(photoUrl, CarId.Create(carId));
        await _repository.AddAsync(photo, cancellationToken);

        return photo.Id;
    }
    
    private async Task<string> UploadLogoAsync(FileDto logo)
    {
        return await _fileService.UploadImage(logo);
    }
}