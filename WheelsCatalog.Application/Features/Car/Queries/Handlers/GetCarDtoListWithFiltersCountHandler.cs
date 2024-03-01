using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListWithFiltersCountHandler : IRequestHandler<GetCarDtoListWithFiltersCountRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetCarDtoListWithFiltersCountHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(GetCarDtoListWithFiltersCountRequest request, CancellationToken cancellationToken)
    {
        return await _unitOfWork.CarRepository.CountWithFiltersAsync(request.CarFilteringParameters, request.PriceFilteringParameters, cancellationToken);
    }
}