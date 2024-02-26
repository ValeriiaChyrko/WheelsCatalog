using FluentValidation;

namespace WheelsCatalog.Application.Features.Model.Queries.Requests.Validators;

public class GetModelDtoRequestValidator : AbstractValidator<GetModelDtoRequest>
{
    public GetModelDtoRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}