using MediatR;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Handlers;

public class CreateBrandHandler : IRequestHandler<CreateBrandRequest, BrandId>
{
    private readonly IBrandRepository _repository;
    private readonly IFileService _fileService;

    public CreateBrandHandler(IBrandRepository repository, IFileService fileService)
    {
        _repository = repository;
        _fileService = fileService;
    }

    public async Task<BrandId> Handle(CreateBrandRequest command, CancellationToken cancellationToken)
    {
        var logoUrl = await UploadLogoAsync(command.BrandDto!.Logo!);
        if (logoUrl == null) throw new OperationCanceledException("Failed to upload logo.");
        
        var brand = Domain.BrandAggregate.Brand.Create(command.BrandDto.Name!, logoUrl, command.BrandDto.Description);
        await _repository.AddAsync(brand, cancellationToken);

        return brand.Id;
    }
    
    private async Task<string> UploadLogoAsync(FileDto logo)
    {
        return await _fileService.UploadImage(logo);
    }
}