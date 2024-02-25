﻿using MediatR;
using WheelsCatalog.Application.Contracts.Persistence.Repository;
using WheelsCatalog.Application.Features.Model.Queries.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Features.Model.Queries.Handlers;

public class GetModelDtoListByBrandCountHandler : IRequestHandler<GetModelDtoListByBrandCountRequest, int>
{
    private readonly IModelRepository _repository;

    public GetModelDtoListByBrandCountHandler(IModelRepository repository)
    {
        _repository = repository;
    } 
    
    public async Task<int> Handle(GetModelDtoListByBrandCountRequest request, CancellationToken cancellationToken)
    {
        var brandId = BrandId.Create(request.Id!.Value);
        return await _repository.CountByBrandIdAsync(brandId, cancellationToken);
    }
}