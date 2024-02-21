using MediatR;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Requests;

public class DeleteBrandRequest : IRequest<BrandId>
{
    public Guid? Id { get; init; }
}