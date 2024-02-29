﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using WheelsCatalog.Application.Common.Errors;
using WheelsCatalog.Application.Common.Exceptions;

namespace WheelsCatalog.Application.Behaviors;

public class DatabaseErrorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        try
        {
            return await next();
        }
        catch (DbUpdateException ex)
        {
            var errors = new List<DataBaseError>();

            foreach (var entry in ex.Entries)
            {
                var members = (await entry.GetDatabaseValuesAsync(cancellationToken))?.Properties;

                if (members != null)
                {
                    errors.AddRange(members
                        .Select(_ => new DataBaseError
                        {
                            Table = entry.Entity.GetType().Name,
                            Message = ex.InnerException?.Message
                        })
                        .GroupBy(error => error.Message) 
                        .Select(group => group.First())
                        .ToList());
                }
                else
                {
                    var table = entry.Entity.GetType().Name;

                    errors.Add(new DataBaseError
                    {
                        Table = table,
                        Message = ex.InnerException?.Message
                    });
                }
            }

            var errorMessage = $"Помилка бази даних для запиту {typeof(TRequest).Name}";
            throw new DatabaseErrorException(errorMessage, ex.InnerException, errors);
        }
    }
}