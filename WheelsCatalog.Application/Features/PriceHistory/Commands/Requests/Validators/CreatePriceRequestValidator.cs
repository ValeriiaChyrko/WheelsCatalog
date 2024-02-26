using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Requests.Validators;

public class CreatePriceRequestValidator : AbstractValidator<CreatePriceRequest>
{
    public CreatePriceRequestValidator()
    {
        RuleFor(x => x.PriceDto)
            .NotNull().WithMessage("ModelDto must not be null.")
            .SetValidator(new RequestPriceDtoValidator()!);
    }
}