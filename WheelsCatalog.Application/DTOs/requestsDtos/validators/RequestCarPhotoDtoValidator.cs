using FluentValidation;
using WheelsCatalog.Application.contracts.persistence;
using WheelsCatalog.Application.dtos.sharedDtos.validators;

namespace WheelsCatalog.Application.dtos.requestsDtos.validators;

public class RequestCarPhotoDtoValidator : AbstractValidator<RequestCarPhotoDto>
{
    private readonly ICarPhotoRepository _repository;
    
    public RequestCarPhotoDtoValidator(ICarPhotoRepository repository)
    {
        _repository = repository;
        RuleFor(p => p.Photo)
            .SetValidator(new FileDtoValidator());
        
        RuleFor(p => p.CarId)
            .GreaterThan(0)
            .MustAsync(ExistInRepository)
            .WithMessage("{PropertyName} does not exist.");
    }
    
    private async Task<bool> ExistInRepository(int id, CancellationToken token)
    {
        var exists = await _repository.IsExistAsync(id, token);
        return exists;
    }
}