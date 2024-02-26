namespace WheelsCatalog.Application.DTOs.sharedDtos;

public class FileDto
{
    public required string FileName { get; init; }  
    public required string ContentType { get; init; }  
    public required byte[] Data { get; init; } 
}