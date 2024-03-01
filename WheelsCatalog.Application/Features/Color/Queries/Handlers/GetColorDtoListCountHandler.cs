using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.Features.Color.Queries.Requests;

namespace WheelsCatalog.Application.Features.Color.Queries.Handlers;

public class GetColorDtoListCountHandler : IRequestHandler<GetColorDtoListCountRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetColorDtoListCountHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(GetColorDtoListCountRequest request, CancellationToken cancellationToken)
    {
        return  await _unitOfWork.ColorRepository.CountAsync(cancellationToken);
    }
}