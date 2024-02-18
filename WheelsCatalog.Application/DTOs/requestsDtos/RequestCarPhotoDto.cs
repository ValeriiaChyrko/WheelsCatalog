using WheelsCatalog.Application.dtos.sharedDtos;

namespace WheelsCatalog.Application.dtos.requestsDtos;

public class RequestCarPhotoDto
{
    public required int CarId { get; set; } 
    public required FileDto Photo { get; set; } 
}