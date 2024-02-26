using MediatR;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListByModelCountRequest : IRequest<int>
{
    public Guid? Id { get; init; }
}