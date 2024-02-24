namespace WheelsCatalog.Application.Contracts.Presentation;

public class PaginationInfo
{
    public int TotalRecords { get; set; }
    public int CurrentPage { get; init; }
    public int TotalPages { get; init; }
    
    public bool HasPreviousPage => (CurrentPage > 0);
    public bool HasNextPage => (CurrentPage + 1 < TotalPages);
}