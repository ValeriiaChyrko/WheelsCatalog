using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Brand.Commands.Requests.Validators;

public class UpdateBrandRequestValidator : AbstractValidator<UpdateBrandRequest>
{
    public UpdateBrandRequestValidator()
    {
        RuleFor(x => x.BrandDto)
            .NotNull().WithMessage("Об'єкт бренду має бути переданий в метод.")
            .SetValidator(new RequestBrandDtoValidator()!);
        
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор бренду є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор бренду не повинен бути пустим GUID.");
    }
}