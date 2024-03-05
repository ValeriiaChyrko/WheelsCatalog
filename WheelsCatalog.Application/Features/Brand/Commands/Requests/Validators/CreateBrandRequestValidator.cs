using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Brand.Commands.Requests.Validators;

public class CreateBrandRequestValidator : AbstractValidator<CreateBrandRequest>
{
    public CreateBrandRequestValidator()
    {
        RuleFor(x => x.BrandDto)
            .NotNull().WithMessage("Об'єкт бренду має бути переданий в метод.")
            .SetValidator(new RequestBrandDtoValidator()!);

        RuleFor(p => p.BrandDto!.Logo)
            .NotNull().WithMessage("Лого для бренду є обов'язковим полем.");
    }
}