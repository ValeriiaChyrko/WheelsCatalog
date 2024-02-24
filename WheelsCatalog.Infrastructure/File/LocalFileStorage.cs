using Microsoft.CSharp.RuntimeBinder;
using WheelsCatalog.Application.Contracts.Infrastructure.File;
using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Infrastructure.file;

public class LocalFileStorage : ILocalFileStorage
{
    public async Task<(string, string)> SaveLocal(FileDto file)
    {
        try
        {
            if (file.Data.Length == 0)
                throw new ArgumentException("File data is empty.", nameof(file));

            var uniqueFileName = GetUniqueFileName(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "src", "images", uniqueFileName);

            await using var fileStream = new FileStream(path, FileMode.Create);
            await fileStream.WriteAsync(file.Data.AsMemory(0, file.Data.Length));

            return (path, uniqueFileName);
        }
        catch (Exception ex)
        {
            throw new RuntimeBinderException($"Error in SaveLocal: {ex.Message}");
        }
    }

    public static string GetUniqueFileName(string fileName)
    {
        fileName = Path.GetFileName(fileName);
        return Path.GetFileNameWithoutExtension(fileName)
               + "_" + Guid.NewGuid().ToString().Substring(0, 6)
               + Path.GetExtension(fileName);
    }
}