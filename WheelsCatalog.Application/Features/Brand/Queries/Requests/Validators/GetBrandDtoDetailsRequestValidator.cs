using FluentValidation;

namespace WheelsCatalog.Application.Features.Brand.Queries.Requests.Validators;

public class GetBrandDtoDetailsRequestValidator : AbstractValidator<GetBrandDtoDetailsRequest>
{
    public GetBrandDtoDetailsRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}