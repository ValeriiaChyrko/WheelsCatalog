using FluentValidation;
using WheelsCatalog.Application.DTOs.requestsDtos.validators;

namespace WheelsCatalog.Application.Features.PriceHistory.Commands.Requests.Validators;

public class CreatePriceRequestValidator : AbstractValidator<CreatePriceRequest>
{
    public CreatePriceRequestValidator()
    {
        RuleFor(x => x.PriceDto)
            .NotNull().WithMessage("Об'єкт ціни повинен бути переданий в метод.")
            .SetValidator(new RequestPriceHistoryDtoValidator()!);
    }
}