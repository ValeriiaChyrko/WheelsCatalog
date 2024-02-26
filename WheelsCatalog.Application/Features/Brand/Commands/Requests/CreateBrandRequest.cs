using MediatR;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Brand.Commands.Requests;

public class CreateBrandRequest : IRequest<BrandId>
{
    public RequestBrandDto? BrandDto { get; init; }
}