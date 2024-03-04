using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Handlers;

public class UpdateBrandHandler : IRequestHandler<UpdateBrandRequest, BrandId>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public UpdateBrandHandler(IUnitOfWork unitOfWork, IFileService fileService)
    {
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }

    public async Task<BrandId> Handle(UpdateBrandRequest command, CancellationToken cancellationToken)
    {
        var brand = await _unitOfWork.BrandRepository.GetByIdAsync(command.Id!.Value, cancellationToken);
        if (brand == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Brand", Id = command.Id!.Value});
        
        var logoUrl = await UploadLogoAsync(command.BrandDto!.Logo!);
        
        brand.Update(command.BrandDto.Name!, logoUrl, command.BrandDto.Description);
        await _unitOfWork.BrandRepository.UpdateAsync(brand, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return brand.Id;
    }
    
    private async Task<string> UploadLogoAsync(FileDto logo)
    {
        var logoUrl = await _fileService.UploadImage(logo);
        if (logoUrl == null) throw new OperationCanceledException("Помилка завантаження фотографії.");
        return logoUrl;
    }
}