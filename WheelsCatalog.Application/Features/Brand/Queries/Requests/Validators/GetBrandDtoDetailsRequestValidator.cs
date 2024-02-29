using FluentValidation;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests.Validators;

public class GetBrandDtoDetailsRequestValidator : AbstractValidator<GetBrandDtoDetailsRequest>
{
    public GetBrandDtoDetailsRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор бренду є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор бренду не повинен бути пустим GUID.");
    }
}