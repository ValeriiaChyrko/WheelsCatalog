using FluentValidation;

namespace WheelsCatalog.Application.Features.Currency.Queries.Requests.Validators;

public class GetCurrencyDtoRequestValidator : AbstractValidator<GetCurrencyDtoRequest>
{
    public GetCurrencyDtoRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Ідентифікатор валюти є обов'язковим полем.")
            .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор валюти не повинен бути пустим GUID.");
    }
}