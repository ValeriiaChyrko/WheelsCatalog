using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

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
        var modelId = request.Id!.Value;
        
        var paginationParameters = request.PaginationParameters;
        var pageSize = paginationParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = paginationParameters?.Page ?? Constants.DefaultPageNumber;
        
        var carsByModel = await _repository.GetAllByModelIdAsync(pageNumber, pageSize, modelId, cancellationToken);
        var respondCarDtos = _mapper.Map<List<RespondCarDto>>(carsByModel);

        return new PaginatedList<RespondCarDto>(respondCarDtos, pageNumber);
    }
}