using Newtonsoft.Json;
using WheelsCatalog.Application.Common.Errors;

namespace WheelsCatalog.Application.Common.Exceptions
{
    public class DatabaseErrorException : Exception
    {
        private static readonly Dictionary<string, string>? ErrorMessages;

        static DatabaseErrorException()
        {
            var json = File.ReadAllText("errors.json");
            ErrorMessages = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        private List<DataBaseError> Errors { get; }

        public DatabaseErrorException(string? message, List<DataBaseError> errors) : base(message)
        {
            Errors = errors;
        }

        public DatabaseErrorException(string? message, Exception? innerException, List<DataBaseError> errors) : base(message, innerException)
        {
            Errors = errors;
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

            if (ErrorMessages == null) return string.Empty;
            foreach (var kvp in ErrorMessages.Where(kvp => errorMessage.Contains(kvp.Key)))
                return kvp.Value;

            return string.Empty;
        }
    }
}