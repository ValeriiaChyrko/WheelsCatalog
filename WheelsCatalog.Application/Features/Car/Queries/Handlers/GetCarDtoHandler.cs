using AutoMapper;
using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.Features.Car.Queries.Requests;

namespace WheelsCatalog.Application.Features.Car.Queries.Handlers;

public class GetCarDtoHandler : IRequestHandler<GetCarDtoRequest, RespondCarDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetCarDtoHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<RespondCarDto> Handle(GetCarDtoRequest request, CancellationToken cancellationToken)
    {
        var car = await _unitOfWork.CarRepository.GetByIdAsync(request.Id!.Value, cancellationToken);
        if (car == null) throw new NotFoundRequestException(new NotFoundError{ Entity = "Car", Id = request.Id!.Value});

        return _mapper.Map<RespondCarDto>(car);
    }
}