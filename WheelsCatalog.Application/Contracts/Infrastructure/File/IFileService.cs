using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Application.contracts.infrastructure.file;

public interface IFileService
{
    Task<string> UploadImage(FileDto file);
}