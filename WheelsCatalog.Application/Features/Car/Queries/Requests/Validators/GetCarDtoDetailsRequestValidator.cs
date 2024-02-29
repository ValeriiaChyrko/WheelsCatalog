using FluentValidation;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests.Validators;

public class GetCarDtoDetailsRequestValidator : AbstractValidator<GetCarDtoDetailsRequest>
{
    public GetCarDtoDetailsRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор автомобіля є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор автомобіля не повинен бути пустим GUID.");
    }
}