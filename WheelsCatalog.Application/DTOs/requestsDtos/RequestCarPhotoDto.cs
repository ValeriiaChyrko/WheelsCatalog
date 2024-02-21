using WheelsCatalog.Application.DTOs.sharedDtos;

namespace WheelsCatalog.Application.DTOs.requestsDtos;

public class RequestCarPhotoDto
{
    public FileDto? Photo { get; set; } 
    public Guid? CarId { get; set; } 
}