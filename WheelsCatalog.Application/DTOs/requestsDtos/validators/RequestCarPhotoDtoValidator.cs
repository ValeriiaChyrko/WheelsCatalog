using FluentValidation;
using WheelsCatalog.Application.DTOs.sharedDtos.validators;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators;

public class RequestCarPhotoDtoValidator : AbstractValidator<RequestCarPhotoDto>
{
    public RequestCarPhotoDtoValidator()
    {
        RuleFor(p => p.Photo)
            .NotEmpty().WithMessage("Фотографія є обов'язковим полем.")
            .SetValidator(new FileDtoValidator()!);
        
        RuleFor(p => p.CarId)
            .NotEmpty().WithMessage("Ідентифікатор автомобіля є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор автомобіля не повинен бути пустим GUID.");
    }
}