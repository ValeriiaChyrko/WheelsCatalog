using MediatR;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Requests;

public class UpdateBrandRequest : IRequest<BrandId>
{
    public Guid? Id { get; init; }
    public RequestBrandDto? BrandDto { get; init; }
}