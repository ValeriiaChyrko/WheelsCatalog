using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoEngineVolumeMinHandler : IRequestHandler<GetCarDtoEngineVolumeMinRequest, double>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetCarDtoEngineVolumeMinHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<double> Handle(GetCarDtoEngineVolumeMinRequest request, CancellationToken cancellationToken)
    {
        return await _unitOfWork.CarRepository.GetCarDtoEngineVolumeMin() ?? 0;
    }
}