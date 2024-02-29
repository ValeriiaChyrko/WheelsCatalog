using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests.Validators;

public class UpdateCarRequestValidator : AbstractValidator<UpdateCarRequest>
{
    public UpdateCarRequestValidator()
    {
        RuleFor(x => x.CarDto)
            .NotNull().WithMessage("Об'єкт автомобіля має бути переданий в метод.")
            .SetValidator(new RequestCarDtoValidator()!);
        
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор автомобіля є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор автомобіля не повинен бути пустим GUID.");
    }
}