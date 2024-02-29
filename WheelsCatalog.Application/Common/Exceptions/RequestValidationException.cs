using WheelsCatalog.Application.Common.Errors;

namespace WheelsCatalog.Application.Common.Exceptions;

public class RequestValidationException : Exception
{
    public List<ValidationError> Errors { get; }

    public RequestValidationException(string message, List<ValidationError> errors) : base(message)
    {
        Errors = errors;
    }

    public RequestValidationException(string message, List<ValidationError> errors, Exception innerException) : base(message, innerException)
    {
        Errors = errors;
    }
    
    public Dictionary<string, List<string>> GetErrors()
    {
        var errorsDict = new Dictionary<string, List<string>>();

        foreach (var error in Errors)
        {
            var key = $"Поле {error.Field} не валідне";

            if (!errorsDict.ContainsKey(key))
            {
                errorsDict[key] = new List<string>();
            }

            errorsDict[key].Add(error.Message);
        }

        return errorsDict;
    }
}