using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoHandler : IRequestHandler<GetModelDtoRequest, RespondModelDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetModelDtoHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<RespondModelDto> Handle(GetModelDtoRequest request, CancellationToken cancellationToken)
    {
        var model = await _unitOfWork.ModelRepository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (model == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Model", Id = request.Id.Value});

        return _mapper.Map<RespondModelDto>(model);
    }
}