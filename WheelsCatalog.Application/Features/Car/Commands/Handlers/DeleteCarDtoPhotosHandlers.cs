using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Car.Commands.Requests;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Commands.Handlers;

public class DeleteCarDtoPhotosHandlers : IRequestHandler<DeleteCarDtoPhotosRequest, CarPhotoId>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public DeleteCarDtoPhotosHandlers(IUnitOfWork unitOfWork, IFileService fileService)
    {
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }

    public async Task<CarPhotoId> Handle(DeleteCarDtoPhotosRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var photo = await _unitOfWork.CarPhotoRepository.GetByIdAsync(id, cancellationToken);
        if (photo == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "CarPhoto", Id = command.Id!.Value});
        
        await DeleteLogoAsync(photo.PhotoUrl);
        await _unitOfWork.CarPhotoRepository.DeleteAsync(photo, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return photo.Id;
    }
    
    private async Task DeleteLogoAsync(string fileName)
    {
        await _fileService.DeleteImage(fileName);
    }
}