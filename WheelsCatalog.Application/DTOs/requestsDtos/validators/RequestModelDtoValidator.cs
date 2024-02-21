using FluentValidation;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators;

public class RequestModelDtoValidator : AbstractValidator<RequestModelDto>
{
    private const int MaxLengthNameLength = 255;
    private const int MaxLengthDescriptionLength = 512;
    
    public RequestModelDtoValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .MaximumLength(MaxLengthNameLength).WithMessage($"{{PropertyName}} must not exceed {MaxLengthNameLength} characters.");
        
        RuleFor(p => p.Description)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(MaxLengthDescriptionLength).WithMessage($"{{PropertyName}} must not exceed {MaxLengthDescriptionLength} characters.")
            .When(p => p.Description != null);

        RuleFor(p => p.BrandId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}