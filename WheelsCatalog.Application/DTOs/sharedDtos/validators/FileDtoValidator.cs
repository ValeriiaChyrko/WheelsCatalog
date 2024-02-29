using FluentValidation;
using WheelsCatalog.Application.Common;

namespace WheelsCatalog.Application.DTOs.sharedDtos.validators;

public class FileDtoValidator : AbstractValidator<FileDto>
{
    private const int MaxLength = Constants.MaxLengthNamePropertyLength;

    public FileDtoValidator()
    {
        RuleFor(dto => dto.FileName)
            .NotEmpty().WithMessage("Назва файлу є обов'язковим полем.")
            .MaximumLength(MaxLength).WithMessage($"Назва файлу не повинна перевищувати {MaxLength} символів.");

        RuleFor(dto => dto.ContentType)
            .NotEmpty().WithMessage("Тип файлу є обов'язковим полем.")
            .MaximumLength(MaxLength).WithMessage($"Тип файлу не повинна перевищувати {MaxLength} символів.");

        RuleFor(dto => dto.Data)
            .NotEmpty().WithMessage("Дані файлу є обов'язковим полем.");
    }
}