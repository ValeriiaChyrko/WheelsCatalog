using WheelsCatalog.Application.Common.Errors;

namespace WheelsCatalog.Application.Common.Exceptions;

public class DatabaseErrorException : Exception
{
    public List<DataBaseError> Errors { get; }

    public DatabaseErrorException(string? message, List<DataBaseError> errors) : base(message)
    {
        Errors = errors;
    }
    
    public DatabaseErrorException(string? message, Exception? innerException, List<DataBaseError> errors) : base(message, innerException)
    {
        Errors = errors;
    }

    public DatabaseErrorException(string message, Exception innerException) : base(message, innerException)
    {
        Errors = new List<DataBaseError>();
    }

    public Dictionary<string, List<string?>> GetErrors()
    {
        var errorsDict = new Dictionary<string, List<string?>>();

        foreach (var error in Errors)
        {
            var key = $"Помилка обробки таблиці {error.Table}";
            var message = MapErrorMessage(error.Message);

            if (!errorsDict.ContainsKey(key))
            {
                errorsDict[key] = new List<string?>();
            }

            errorsDict[key].Add(message);
        }

        return errorsDict;
    }

    private static string? MapErrorMessage(string? errorMessage)
    {
        if (errorMessage == null) return null;

        if (errorMessage.Contains("DELETE statement conflicted with the REFERENCE constraint"))
            return "Не вдалося видалити запис, оскільки існують пов'язані з ним об'єкти. " +
                   "Будь ласка, спочатку видаліть усі залежні об'єкти, а потім спробуйте знову.";

        if (errorMessage.Contains("The INSERT statement conflicted with the FOREIGN KEY constraint"))
            return
                "Не вдалося створити запис, оскільки один або декілька пов'язаних з ним об'єктів не знайдено в базі даних. " +
                "Перевірте, чи існують об'єкти, до яких ви посилаєтеся, введіть вірні дані, а потім спробуйте знову.";
        
        if (errorMessage.Contains("The UPDATE statement conflicted with the FOREIGN KEY constraint"))
            return
                "Не вдалося оновити запис, оскільки один або декілька пов'язаних з ним об'єктів не знайдено в базі даних. " +
                "Перевірте, чи існують об'єкти, до яких ви посилаєтеся, введіть вірні дані, а потім спробуйте знову.";

        if (errorMessage.Contains("Cannot insert duplicate key row in object 'dbo.BrandEntityModel' with unique index 'IX_BrandEntityModel_Name"))
            return 
                "Бренд з таким іменем вже існує.";
        
        if (errorMessage.Contains("Cannot insert duplicate key row in object 'dbo.ModelEntityModel' with unique index 'IX_ModelEntityModel_Name'"))
            return 
                "Модель з таким іменем вже існує.";
        
        return string.Empty;
    }
}