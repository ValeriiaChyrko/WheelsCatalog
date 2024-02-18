using FluentValidation;

namespace WheelsCatalog.Application.dtos.sharedDtos.validators;

public class CurrencyValidator : AbstractValidator<CurrencyDto>
{
    private const int MaxLength = 16;
    
    public CurrencyValidator()
    {
        RuleFor(dto => dto.Acronym)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(MaxLength).WithMessage($"{{PropertyName}} must not exceed {MaxLength} characters.")
            .Must(acronym => acronym == acronym.ToUpper()).WithMessage("{PropertyName} must contain only uppercase characters.");

    }
}