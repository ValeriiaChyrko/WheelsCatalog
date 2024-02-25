using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Model.Queries.Requests;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListHandler : IRequestHandler<GetModelDtoListRequest, PaginatedList<RespondModelDto>>
{
    private readonly IModelRepository _repository;
    private readonly IMapper _mapper;

    public GetModelDtoListHandler(IModelRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondModelDto>> Handle(GetModelDtoListRequest request, CancellationToken cancellationToken)
    {
        var paginationParameters = request.PaginationParameters;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        
        var models = await _repository.ListAsync(pageNumber, pageSize, cancellationToken);
        var respondModelDtos = _mapper.Map<List<RespondModelDto>>(models);

        return new PaginatedList<RespondModelDto>(respondModelDtos, pageNumber);
    }
}