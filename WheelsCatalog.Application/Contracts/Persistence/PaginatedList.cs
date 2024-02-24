using WheelsCatalog.Application.Contracts.Presentation;

namespace WheelsCatalog.Application.Contracts.Persistence;

public class PaginatedList<T>
{
    public IReadOnlyList<T> Data { get; private set; }
    public PaginationInfo Pagination { get; private set; }

    public PaginatedList(IReadOnlyList<T> data, int pageSize, int currentPage, int totalCount)
    {
        Data = data;
        Pagination = new PaginationInfo
        {
            TotalRecords = totalCount,
            CurrentPage = currentPage,
            TotalPages = pageSize != 0 ? (int)Math.Ceiling(totalCount / (double)pageSize) : 0,
        };
    }
}