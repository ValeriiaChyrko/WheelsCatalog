using FluentValidation;

namespace WheelsCatalog.Application.DTOs.requestsDtos.validators
{
    public class RequestPriceHistoryDtoValidator : AbstractValidator<RequestPriceHistoryDto>
    {
        public RequestPriceHistoryDtoValidator()
        {
            RuleFor(dto => dto.Amount)
                .GreaterThan(0).WithMessage("Ціна автомобіля повинна бути більшою за нуль.");

            RuleFor(dto => dto.Date)
                .NotEmpty().WithMessage("Дата початку дії ціни є обов'язковим полем.")
                .Must(BeValidDate).WithMessage("Введена дата має бути коректною.");
            
            RuleFor(dto => dto.CurrencyId)
                .NotEmpty().WithMessage("Ідентифікатор валюти є обов'язковим полем.")
                .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор валюти не повинен бути пустим GUID.");
            
            RuleFor(dto => dto.CarId)
                .NotEmpty().WithMessage("Ідентифікатор автомобіля є обов'язковим полем.")
                .Must(id => id != Guid.Empty).WithMessage("Ідентифікатор автомобіля не повинен бути пустим GUID.");
        }

        private static bool BeValidDate(DateTime? date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}