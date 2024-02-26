using FluentValidation;
using WheelsCatalog.Application.DTOs.sharedDtos.validators;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests.Validators;

public class CreateCarDtoPhotosRequestValidator : AbstractValidator<CreateCarDtoPhotosRequest>
{
    public CreateCarDtoPhotosRequestValidator()
    {
        RuleFor(x => x.Photo)
            .NotNull().WithMessage("Photo must not be null.")
            .SetValidator(new FileDtoValidator()!);
        
        RuleFor(x => x.CarId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}