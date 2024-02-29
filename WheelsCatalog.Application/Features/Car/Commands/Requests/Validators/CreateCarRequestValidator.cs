using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests.Validators;

public class CreateCarRequestValidator : AbstractValidator<CreateCarRequest>
{
    public CreateCarRequestValidator()
    {
        RuleFor(x => x.CarDto)
            .NotNull().WithMessage("Об'єкт автомобіля повинен бути переданий в метод.")
            .SetValidator(new RequestCarDtoValidator()!);
    }
}