using MediatR;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListCountRequest : IRequest<int> { }