using WheelsCatalog.Application.Contracts.Presentation;

namespace WheelsCatalog.Application.Contracts.Persistence;

public class PaginatedList<T>
{
    public IReadOnlyList<T> Data { get; private set; }
    public PaginationInfo Pagination { get; private set; }

    public PaginatedList(IReadOnlyList<T> data, int currentPage)
    {
        Data = data;
        Pagination = new PaginationInfo
        {
            CurrentPage = currentPage
        };
    }
}