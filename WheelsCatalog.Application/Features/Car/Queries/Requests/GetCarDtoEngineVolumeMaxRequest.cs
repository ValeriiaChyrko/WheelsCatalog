using MediatR;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoEngineVolumeMaxRequest : IRequest<double> { }