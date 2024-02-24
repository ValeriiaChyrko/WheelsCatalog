using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Brand.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Handlers;

public class DeleteBrandHandler : IRequestHandler<DeleteBrandRequest, BrandId>
{
    private readonly IBrandRepository _repository;

    public DeleteBrandHandler(IBrandRepository repository)
    {
        _repository = repository;
    }

    public async Task<BrandId> Handle(DeleteBrandRequest command, CancellationToken cancellationToken)
    {
        var id = command.Id!.Value;
        
        var brand = await _repository.GetByIdAsync(id, cancellationToken);
        if (brand == null) throw new NotFoundRequestException(id);
        
        await _repository.DeleteAsync(brand, cancellationToken);
        return brand.Id;
    }
}