﻿using FluentValidation;
using MediatR;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;

namespace WheelsCatalog.Application.Behaviors;

public sealed class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!_validators.Any()) return await next();

        var context = new ValidationContext<TRequest>(request);

        var errors = _validators
            .SelectMany(validator => validator.Validate(context).Errors
                .Select(error => new ValidationError
                {
                    Entity = typeof(TRequest).Name,
                    Field = error.PropertyName,
                    Message = error.ErrorMessage
                }))
            .ToList();

        if (!errors.Any()) return await next();
        
        var errorMessage = $"Помилка валідації для запиту {typeof(TRequest).Name}";
        throw new RequestValidationException(errorMessage, errors, new Exception("Fluent validation exception. See inner exceptions."));
    }
}