using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoListDetailsHandler : IRequestHandler<GetCarDtoListDetailsRequest, PaginatedList<RespondCarDtoDetails>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetCarDtoListDetailsHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PaginatedList<RespondCarDtoDetails>> Handle(GetCarDtoListDetailsRequest request, CancellationToken cancellationToken)
    {
        var carFilteringParameters = request.CarFilteringParameters;
        var pageSize = carFilteringParameters?.Limit ?? Constants.DefaultPageSize;
        var pageNumber = carFilteringParameters?.Page ?? Constants.DefaultPageNumber;
        
        var carEntities = await _unitOfWork.CarRepository.GetAllByFilterAsync(
            pageNumber, 
            pageSize, 
            request.CarFilteringParameters,
            request.PriceFilteringParameters,
            cancellationToken);
        
        var cars = new List<RespondCarDtoDetails>();

        var actualPriceDate = request.PriceFilteringParameters?.Date?.Date ?? DateTime.Today.Date;
        foreach (var car in carEntities)
        {
            var respond = _mapper.Map<RespondCarDtoDetails>(car);
            respond.ModelName = await _unitOfWork.CarRepository.GetCarModelNameAsync(car.ModelId.Value, cancellationToken) ?? string.Empty;
            respond.BrandName = await _unitOfWork.CarRepository.GetCarBrandNameAsync(car.ModelId.Value, cancellationToken) ?? string.Empty;
            respond.ColorName = await _unitOfWork.CarRepository.GetCarColorNameAsync(car.ColorId.Value, cancellationToken) ?? string.Empty;

            var photos = await _unitOfWork.CarPhotoRepository.GetAllPhotosByCarId(car.Id);
            respond.PhotoUrl = photos.Select(entity => entity.PhotoUrl).ToList();
            
            var price = await _unitOfWork.PriceHistoryRepository.GetActualPriceByCarIdStartByDateAsync(car.Id.Value, actualPriceDate, cancellationToken);
            respond.Price = _mapper.Map<RespondPriceDto>(price);
            if (price != null) respond.Price.CurrencyAcronym = _unitOfWork.CurrencyRepository.GetCurrencyAcronym(price.CurrencyId) ?? string.Empty;
            
            cars.Add(respond);
        }

        return new PaginatedList<RespondCarDtoDetails>(cars, pageNumber, pageSize);
    }
}