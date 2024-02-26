using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Handlers;

public class UpdateBrandHandler : IRequestHandler<UpdateBrandRequest, BrandId>
{
    private readonly IBrandRepository _repository;
    private readonly IFileService _fileService;

    public UpdateBrandHandler(IBrandRepository repository, IFileService fileService)
    {
        _repository = repository;
        _fileService = fileService;
    }

    public async Task<BrandId> Handle(UpdateBrandRequest command, CancellationToken cancellationToken)
    {
        var brand = await _repository.GetByIdAsync(command.Id!.Value, cancellationToken);
        if (brand == null) throw new NotFoundRequestException(command.Id!.Value);
        
        var logoUrl = await UploadLogoAsync(command.BrandDto!.Logo!);
        if (logoUrl == null) throw new OperationCanceledException("Failed to upload logo.");
        
        brand.Update(command.BrandDto.Name!, logoUrl, command.BrandDto.Description);
        await _repository.UpdateAsync(brand, cancellationToken);

        return brand.Id;
    }
    
    private async Task<string> UploadLogoAsync(FileDto logo)
    {
        return await _fileService.UploadImage(logo);
    }
}