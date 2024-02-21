using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListHandler : IRequestHandler<GetModelDtoListRequest, List<RespondModelDto>>
{
    private readonly IModelRepository _repository;
    private readonly IMapper _mapper;

    public GetModelDtoListHandler(IModelRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<RespondModelDto>> Handle(GetModelDtoListRequest request, CancellationToken cancellationToken)
    {
        var models = await _repository.ListAsync(cancellationToken);
        return models.Count == 0 ? new List<RespondModelDto>() : _mapper.Map<List<RespondModelDto>>(models);
    }
}