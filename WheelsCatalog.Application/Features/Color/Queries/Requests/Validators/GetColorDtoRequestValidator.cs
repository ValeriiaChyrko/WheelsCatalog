using FluentValidation;

namespace WheelsCatalog.Application.Features.Color.Queries.Requests.Validators;

public class GetColorDtoRequestValidator : AbstractValidator<GetColorDtoRequest>
{
    public GetColorDtoRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}