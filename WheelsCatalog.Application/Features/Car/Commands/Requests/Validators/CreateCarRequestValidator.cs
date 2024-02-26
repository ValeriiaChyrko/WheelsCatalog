using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests.Validators;

public class CreateCarRequestValidator : AbstractValidator<CreateCarRequest>
{
    public CreateCarRequestValidator()
    {
        RuleFor(x => x.CarDto)
            .NotNull().WithMessage("Photo must not be null.")
            .SetValidator(new RequestCarDtoValidator()!);
    }
}