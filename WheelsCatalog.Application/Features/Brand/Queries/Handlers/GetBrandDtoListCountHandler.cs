using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Brand.Queries.Requests;

namespace WheelsCatalog.Application.Features.Brand.Queries.Handlers;

public class GetBrandDtoListCountHandler : IRequestHandler<GetBrandDtoListWithFiltersCountRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetBrandDtoListCountHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(GetBrandDtoListWithFiltersCountRequest request, CancellationToken cancellationToken)
    {
        return await _unitOfWork.BrandRepository.CountWithFiltersAsync(request.FilteringParameters, cancellationToken);
    }
}