using FluentValidation;
using WheelsCatalog.Application.contracts.persistence;

namespace WheelsCatalog.Application.dtos.sharedDtos.validators;

public class ModelDtoValidator : AbstractValidator<ModelDto>
{
    private const int MaxLength = 255;
    private readonly IModelRepository _repository;

    public ModelDtoValidator(IModelRepository repository)
    {
        _repository = repository;
        RuleFor(dto => dto.Name)
            .NotNull()
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(MaxLength).WithMessage($"{{PropertyName}} must not exceed {MaxLength} characters.");
        
        RuleFor(p => p.BrandId)
            .GreaterThan(0)
            .MustAsync(ExistInRepository)
            .WithMessage("{PropertyName} does not exist.");
    }
    
    private async Task<bool> ExistInRepository(int id, CancellationToken token)
    {
        return await _repository.IsExistAsync(id, token);   
    }
}