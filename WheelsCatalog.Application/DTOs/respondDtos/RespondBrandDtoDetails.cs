﻿namespace WheelsCatalog.Application.DTOs.respondDtos;

public class RespondBrandDtoDetails
{
    public Guid Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string LogoUrl { get; set; }  = string.Empty;
    public string? Description { get; set; }

    public IReadOnlyList<RespondModelDto>? ModelDtos { get; set; } 
}