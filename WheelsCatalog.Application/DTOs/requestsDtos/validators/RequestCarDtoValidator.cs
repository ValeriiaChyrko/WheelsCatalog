using FluentValidation;
using WheelsCatalog.Application.Common;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators;

public class RequestCarDtoValidator : AbstractValidator<RequestCarDto>
{
    private const int MaxLengthDescriptionLength = Constants.MaxLengthDescriptionPropertyLength;
    
    public RequestCarDtoValidator()
    {
        RuleFor(dto => dto.Description)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(MaxLengthDescriptionLength)
            .WithMessage($"{{PropertyName}} must not exceed {MaxLengthDescriptionLength} characters.")
            .When(p => p.Description != null);

        RuleFor(dto => dto.EngineVolume)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
        
        RuleFor(p => p.ModelId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
        
        RuleFor(p => p.ColorId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}