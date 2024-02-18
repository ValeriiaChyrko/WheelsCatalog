using System.Text.RegularExpressions;
using FluentValidation;
using WheelsCatalog.Application.contracts.persistence;

namespace WheelsCatalog.Application.dtos.sharedDtos.validators;

public partial class CarDtoValidator : AbstractValidator<CarDto>
{
    private const int MaxLengthDescriptionLength = 512;
    private readonly ICarRepository _repository;

    public CarDtoValidator(ICarRepository repository)
    {
        _repository = repository;
        RuleFor(dto => dto.Description)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(MaxLengthDescriptionLength)
            .WithMessage($"{{PropertyName}} must not exceed {MaxLengthDescriptionLength} characters.")
            .When(p => p.Description != null);

        RuleFor(dto => dto.EngineVolume)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
            .Must(BeAnInteger).WithMessage("EngineVolume must be an integer.");
        
        RuleFor(p => p.BrandId)
            .GreaterThan(0)
            .MustAsync(ExistInRepository)
            .WithMessage("{PropertyName} does not exist.");
        
        RuleFor(p => p.ModelId)
            .GreaterThan(0)
            .MustAsync(ExistInRepository)
            .WithMessage("{PropertyName} does not exist.");
        
        RuleFor(p => p.ColorId)
            .GreaterThan(0)
            .MustAsync(ExistInRepository)
            .WithMessage("{PropertyName} does not exist.");
    }

    [GeneratedRegex("^\\d+$")]
    private static partial Regex Regex();
    
    private static bool BeAnInteger(int value)
    {
        return Regex().IsMatch(value.ToString());
    }
    
    private async Task<bool> ExistInRepository(int id, CancellationToken token)
    {
        return await _repository.IsExistAsync(id, token);
    }
}