using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Application.Contracts.Infrastructure.File;

public interface ILocalFileStorage
{
    Task<(string, string)> SaveLocal(FileDto file);
}