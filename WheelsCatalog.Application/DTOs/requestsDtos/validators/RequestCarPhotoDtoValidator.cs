using FluentValidation;
using WheelsCatalog.Application.DTOs.sharedDtos.validators;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators;

public class RequestCarPhotoDtoValidator : AbstractValidator<RequestCarPhotoDto>
{
    
    public RequestCarPhotoDtoValidator()
    {
        RuleFor(p => p.Photo)
            .NotNull().WithMessage("{PropertyName} is required.")
            .SetValidator(new FileDtoValidator()!);
        
        RuleFor(p => p.CarId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}