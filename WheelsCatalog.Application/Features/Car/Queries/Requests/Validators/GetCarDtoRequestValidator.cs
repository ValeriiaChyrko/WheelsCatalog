using FluentValidation;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests.Validators;

public class GetCarDtoRequestValidator : AbstractValidator<GetCarDtoRequest>
{
    public GetCarDtoRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
    }
}