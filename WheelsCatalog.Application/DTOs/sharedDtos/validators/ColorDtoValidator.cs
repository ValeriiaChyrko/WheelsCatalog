using FluentValidation;

namespace WheelsCatalog.Application.dtos.sharedDtos.validators;

public class ColorDtoValidator : AbstractValidator<ColorDto>
{
    private const int MaxLength = 255;

    public ColorDtoValidator()
    {
        RuleFor(dto => dto.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(MaxLength).WithMessage($"{{PropertyName}} must not exceed {MaxLength} characters.");
        
        RuleFor(dto => dto.HexCode)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Matches("^#([A-Fa-f0-9]{6})$").WithMessage("{PropertyName} must be in the format '#RRGGBB'.");
    }
}