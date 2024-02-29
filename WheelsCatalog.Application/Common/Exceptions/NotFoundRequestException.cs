using WheelsCatalog.Application.Common.Errors;

namespace WheelsCatalog.Application.Common.Exceptions;

public class NotFoundRequestException : Exception
{
    public NotFoundError Error { get; }
    
    public NotFoundRequestException(string message, NotFoundError error) : base(message)
    {
        Error = error;
    }
    
    public NotFoundRequestException(NotFoundError error) : base(
        "Помилка бази даних для запиту на отримання даних",
        new Exception($"The entity {error.Entity} with the key {error.Id} was not found at database."))
    {
        Error = error;
    }
    
    public Dictionary<string, List<string>> GetErrors()
    {
        var errorsDict = new Dictionary<string, List<string>>();
        errorsDict.Add("Помилка обробки таблиці CarEntityModel", 
            new List<string> { $"Об'єкт з ідентифікатором '{Error.Id}' не знайдено в базі даних." });

        return errorsDict;
    }
    
}