using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.Brand.Commands.Requests.Validators;

public class CreateBrandRequestValidator : AbstractValidator<CreateBrandRequest>
{
    public CreateBrandRequestValidator()
    {
        RuleFor(x => x.BrandDto)
            .NotNull().WithMessage("BrandDto must not be null.")
            .SetValidator(new RequestBrandDtoValidator()!);
    }
}