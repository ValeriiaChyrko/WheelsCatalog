using FluentValidation;
using WheelsCatalog.Application.dtos.sharedDtos.validators;

namespace WheelsCatalog.Application.dtos.requestsDtos.validators;

public class RequestBrandDtoValidator : AbstractValidator<RequestBrandDto>
{
    private const int MaxLengthNameLength = 255;
    private const int MaxLengthDescriptionLength = 512;
    
    public RequestBrandDtoValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(MaxLengthNameLength).WithMessage($"{{PropertyName}} must not exceed {MaxLengthNameLength} characters.");
        
        RuleFor(p => p.Logo)
            .SetValidator(new FileDtoValidator());
        
        RuleFor(p => p.Description)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(MaxLengthDescriptionLength).WithMessage($"{{PropertyName}} must not exceed {MaxLengthDescriptionLength} characters.")
            .When(p => p.Description != null);
    }
}