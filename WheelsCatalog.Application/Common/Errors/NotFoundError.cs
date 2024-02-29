namespace WheelsCatalog.Application.Common.Errors;

public class NotFoundError
{
    public string Entity { get; set; } = string.Empty;
    public Guid Id { get; set; }
}