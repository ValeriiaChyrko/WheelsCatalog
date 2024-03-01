using MediatR;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Handlers;

public class CreateBrandHandler : IRequestHandler<CreateBrandRequest, BrandId>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public CreateBrandHandler(IUnitOfWork unitOfWork, IFileService fileService)
    {
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }
    
    public async Task<BrandId> Handle(CreateBrandRequest command, CancellationToken cancellationToken)
    {
        var logoUrl = await UploadLogoAsync(command.BrandDto!.Logo!);
        if (logoUrl == null) throw new OperationCanceledException("Помилка завантаження фотографії");
        
        var brand = Domain.BrandAggregate.Brand.Create(command.BrandDto.Name!, logoUrl, command.BrandDto.Description);
        await _unitOfWork.BrandRepository.AddAsync(brand, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return brand.Id;
    }
    
    private async Task<string> UploadLogoAsync(FileDto logo)
    {
        return await _fileService.UploadImage(logo);
    }
}