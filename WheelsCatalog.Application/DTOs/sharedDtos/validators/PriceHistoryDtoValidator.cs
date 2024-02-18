using FluentValidation;
using WheelsCatalog.Application.contracts.persistence;

namespace WheelsCatalog.Application.dtos.sharedDtos.validators;

public class PriceHistoryDtoValidator : AbstractValidator<PriceHistoryDto>
{
    private readonly IPriceHistoryRepository _repository;

    public PriceHistoryDtoValidator(IPriceHistoryRepository repository)
    {
        _repository = repository;
        RuleFor(dto => dto.Price)
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than zero.");

        RuleFor(dto => dto.StartDate)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Must(BeValidDate).WithMessage("{PropertyName} must be a valid date.");

        RuleFor(dto => dto.CarId)
            .GreaterThan(0)
            .MustAsync(ExistInRepository)
            .WithMessage("{PropertyName} does not exist.");

        RuleFor(dto => dto.CurrencyId)
            .GreaterThan(0)
            .MustAsync(ExistInRepository)
            .WithMessage("{PropertyName} does not exist.");
    }
    
    private async Task<bool> ExistInRepository(int id, CancellationToken token)
    {
        return await _repository.IsExistAsync(id, token);
    }
    
    private static bool BeValidDate(DateTime date)
    {
        return !date.Equals(default(DateTime));
    }
}