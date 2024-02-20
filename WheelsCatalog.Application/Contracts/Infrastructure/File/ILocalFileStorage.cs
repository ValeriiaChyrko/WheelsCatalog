using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Application.contracts.infrastructure.file;

public interface ILocalFileStorage
{
    Task<(string, string)> SaveLocal(FileDto file);
}