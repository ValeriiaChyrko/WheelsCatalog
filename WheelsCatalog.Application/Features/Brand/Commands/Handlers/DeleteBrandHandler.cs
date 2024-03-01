using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Handlers;

public class DeleteBrandHandler : IRequestHandler<DeleteBrandRequest, BrandId>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public DeleteBrandHandler(IUnitOfWork unitOfWork, IFileService fileService)
    {
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }


    public async Task<BrandId> Handle(DeleteBrandRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var brand = await _unitOfWork.BrandRepository.GetByIdAsync(id, cancellationToken);
        if (brand == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Brand", Id = id});
        
        await DeleteLogoAsync(brand.LogoUrl);
        await _unitOfWork.BrandRepository.DeleteAsync(brand, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return brand.Id;
    }
    
    private async Task DeleteLogoAsync(string fileName)
    {
        await _fileService.DeleteImage(fileName);
    }
}