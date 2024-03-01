using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListWithFiltersCountHandler : IRequestHandler<GetModelDtoListCountRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetModelDtoListWithFiltersCountHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(GetModelDtoListCountRequest request, CancellationToken cancellationToken)
    {
        return await _unitOfWork.ModelRepository.CountWithFiltersAsync(request.FilteringParameters, cancellationToken);
    }
}