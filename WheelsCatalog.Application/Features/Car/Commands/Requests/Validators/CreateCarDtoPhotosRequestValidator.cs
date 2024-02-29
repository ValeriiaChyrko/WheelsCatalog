using FluentValidation;
using WheelsCatalog.Application.DTOs.sharedDtos.validators;

namespace WheelsCatalog.Application.Features.Car.Commands.Requests.Validators;

public class CreateCarDtoPhotosRequestValidator : AbstractValidator<CreateCarDtoPhotosRequest>
{
    public CreateCarDtoPhotosRequestValidator()
    {
        RuleFor(x => x.Photo)
            .NotNull().WithMessage("Об'єкт фото має бути передано в метод.")
            .SetValidator(new FileDtoValidator()!);
        
        RuleFor(x => x.CarId)
            .NotEmpty().WithMessage("Ідентифікатор автомобіля є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор автомобіля не повинен бути пустим GUID.");
    }
}