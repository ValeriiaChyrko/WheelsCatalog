using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoEngineVolumeMaxHandler : IRequestHandler<GetCarDtoEngineVolumeMaxRequest, double>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetCarDtoEngineVolumeMaxHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<double> Handle(GetCarDtoEngineVolumeMaxRequest request, CancellationToken cancellationToken)
    {
        return await _unitOfWork.CarRepository.GetCarDtoEngineVolumeMax() ?? 0;
    }
}