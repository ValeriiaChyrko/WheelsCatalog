using FluentValidation;
using WheelsCatalog.Application.Contracts.Presentation.Validators;

namespace WheelsCatalog.Application.Features.Car.Queries.Requests.Validators;

public class GetCarDtoListByModelRequestValidator : AbstractValidator<GetCarDtoListByModelRequest>
{
    public GetCarDtoListByModelRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull().WithMessage("{PropertyName} is required.")
            .Must(id => id != Guid.Empty).WithMessage("{PropertyName} must not be empty GUID.");
        
        RuleFor(x => x.PaginationParameters)
            .SetValidator(new PaginationParametersValidator()!)
            .When(x=>x.PaginationParameters != null);
    }
}