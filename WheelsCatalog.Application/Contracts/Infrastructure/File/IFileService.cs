using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Application.Contracts.Infrastructure.File;

public interface IFileService
{
    Task<string> UploadImage(FileDto file);
    Task DeleteImage(string fileName);
}