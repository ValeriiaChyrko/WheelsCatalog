using MediatR;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class CreateCarDtoPhotosHandler : IRequestHandler<CreateCarDtoPhotosRequest, CarPhotoId>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public CreateCarDtoPhotosHandler(IUnitOfWork unitOfWork, IFileService fileService)
    {
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }

    public async Task<CarPhotoId> Handle(CreateCarDtoPhotosRequest command, CancellationToken cancellationToken)
    {
        var photoUrl = await UploadLogoAsync(command.Photo!);
        if (photoUrl == null) throw new OperationCanceledException("Помилка завантаження фотографії.");
        
        var carId = command.CarId!.Value;
        var photo = Domain.CarAggregate.Entities.CarPhotoEntity.Create(photoUrl, CarId.Create(carId));
        await _unitOfWork.CarPhotoRepository.AddAsync(photo, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return photo.Id;
    }
    
    private async Task<string> UploadLogoAsync(FileDto logo)
    {
        return await _fileService.UploadImage(logo);
    }
}