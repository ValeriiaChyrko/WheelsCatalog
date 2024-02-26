using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests.Validators;

public class UpdateCarRequestValidator : AbstractValidator<UpdateCarRequest>
{
    public UpdateCarRequestValidator()
    {
        RuleFor(x => x.CarDto)
            .NotNull().WithMessage("Photo must not be null.")
            .SetValidator(new RequestCarDtoValidator()!);
        
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}