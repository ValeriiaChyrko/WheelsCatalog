﻿using MediatR;
using WheelsCatalog.Application.Contracts.Persistence;
using WheelsCatalog.Application.Contracts.Presentation;
using WheelsCatalog.Application.DTOs.respondDtos;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests;

public class GetCarDtoListByPriceRequest : IRequest<PaginatedList<RespondCarDto>> 
{
    public PriceFilteringParameters? PriceFilteringParameters { get; init; }
    public PaginationParameters? PaginationParameters { get; init; }
}