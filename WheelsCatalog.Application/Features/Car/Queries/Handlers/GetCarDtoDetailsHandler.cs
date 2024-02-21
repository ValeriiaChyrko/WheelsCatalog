using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoDetailsHandler : IRequestHandler<GetCarDtoDetailsRequest, RespondCarDtoDetails>
{
    private readonly ICarRepository _carRepository;
    private readonly ICarPhotoRepository _carPhotoRepository;
    private readonly IMapper _mapper;

    public GetCarDtoDetailsHandler(IMapper mapper, ICarRepository carRepository, ICarPhotoRepository carPhotoRepository)
    {
        _mapper = mapper;
        _carRepository = carRepository;
        _carPhotoRepository = carPhotoRepository;
    }

    public async Task<RespondCarDtoDetails> Handle(GetCarDtoDetailsRequest request, CancellationToken cancellationToken)
    {
        var car = await _carRepository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (car == null) throw new NotFoundRequestException(request.Id!.Value);

        var respond = _mapper.Map<RespondCarDtoDetails>(car);
        respond.ModelName = _carRepository.GetCarModelName(car.Id) ?? throw new InvalidOperationException();
        respond.ColorName = _carRepository.GetCarColorName(car.Id) ?? throw new InvalidOperationException();

        var photos = await _carPhotoRepository.GetAllPhotosByCarIdName(car.Id);
        respond.PhotoUrl = photos.Select(entity => entity.PhotoUrl).ToList();

        return respond;
    }
}