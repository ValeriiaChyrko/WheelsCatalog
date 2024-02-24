using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListByModelHandler : IRequestHandler<GetCarDtoListByModelRequest, PaginatedList<RespondCarDto>>
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public GetCarDtoListByModelHandler(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondCarDto>> Handle(GetCarDtoListByModelRequest request, CancellationToken cancellationToken)
    {
        var modelId = ModelId.Create(request.Id!.Value);
        
        var totalItems = await _repository.CountByModelIdAsync(modelId, cancellationToken);
        var pageSize = request.PaginationParameters?.Limit == 0 ? totalItems : request.PaginationParameters!.Limit;
        var pageNumber = request.PaginationParameters?.Page == 0 ? 1 : request.PaginationParameters!.Page;
        
        var carsByModel = await _repository.GetAllByModelIdAsync(pageNumber, pageSize, modelId, cancellationToken);
        var respondCarDtos = _mapper.Map<List<RespondCarDto>>(carsByModel);

        return new PaginatedList<RespondCarDto>(respondCarDtos, pageSize, pageNumber, totalItems);
    }
}