namespace WheelsCatalog.Application.Contracts.Infrastructure.File;

public interface ICloudFileStorage
{
    Task<string> UploadToCloud(FileStream stream, string fileName);
}