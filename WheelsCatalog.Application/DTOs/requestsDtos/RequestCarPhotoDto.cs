using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Application.DTOs.requestsDtos;

public class RequestCarPhotoDto
{
    public FileDto? Photo { get; init; } 
    public Guid? CarId { get; init; } 
}