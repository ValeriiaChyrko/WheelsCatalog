namespace WheelsCatalog.Application.Common.Exceptions;

public class NotFoundRequestException : Exception
{
    public NotFoundRequestException(string message) : base(message)
    {
    }
    
    public NotFoundRequestException(Guid objectId) : base($"Object with id: {objectId} was not found in database")
    {
    }
    
}