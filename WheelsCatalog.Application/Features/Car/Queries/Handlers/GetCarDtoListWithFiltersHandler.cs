using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListWithFiltersHandler : IRequestHandler<GetCarDtoListWithFiltersRequest, PaginatedList<RespondCarDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetCarDtoListWithFiltersHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondCarDto>> Handle(GetCarDtoListWithFiltersRequest request, CancellationToken cancellationToken)
    {
        var carFilteringParameters = request.CarFilteringParameters;
        var pageSize = carFilteringParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = carFilteringParameters?.Page ?? Constants.DefaultPageNumber;
        
        var cars = await _unitOfWork.CarRepository.GetAllByFilterAsync(
            pageNumber, 
            pageSize, 
            request.CarFilteringParameters,
            request.PriceFilteringParameters,
            cancellationToken);
        var respondCarDtos = _mapper.Map<List<RespondCarDto>>(cars);

        return new PaginatedList<RespondCarDto>(respondCarDtos, pageNumber, pageSize);
    }
}