using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Diagnostics;
using WheelsCatalog.Application.Common.Exceptions;

namespace WheelsCatalog.API.Extensions;

public static class ErrorHandlerExtensions
{
    public static void UseErrorHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature == null) return;

                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                context.Response.ContentType = "application/json";

                context.Response.StatusCode = contextFeature.Error switch
                {
                    BadRequestException => (int)HttpStatusCode.BadRequest,
                    RequestValidationException => (int)HttpStatusCode.BadRequest,
                    OperationCanceledException => (int)HttpStatusCode.ServiceUnavailable,
                    NotFoundRequestException => (int)HttpStatusCode.NotFound,
                    DatabaseErrorException => (int)HttpStatusCode.InternalServerError,
                    _ => (int)HttpStatusCode.InternalServerError
                };

                var errorResponse = new
                {
                    statusCode = context.Response.StatusCode,
                    message = contextFeature.Error.Message,
                    innerException = contextFeature.Error.InnerException?.Message,
                    clientException = GetErrorBody(contextFeature.Error),
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
            });
        });
    }

    private static Dictionary<string, List<string?>>? GetErrorBody(Exception error)
    {
        if (error is RequestValidationException validationException)
            return validationException.GetErrors()!;

        if (error is DatabaseErrorException databaseErrorException)
            return databaseErrorException.GetErrors();
        
        if (error is NotFoundRequestException notFoundRequestException)
            return notFoundRequestException.GetErrors();

        return null;
    }
}