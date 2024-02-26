using FluentValidation;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests.Validators;

public class GetCarDtoDetailsRequestValidator : AbstractValidator<GetCarDtoDetailsRequest>
{
    public GetCarDtoDetailsRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}