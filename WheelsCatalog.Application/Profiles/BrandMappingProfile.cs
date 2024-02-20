using AutoMapper;
using WheelsCatalog.Application.contracts.infrastructure.file;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.DTOs.respondDtos;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Domain.BrandAggregate;

namespace WheelsCatalog.Application.profiles;

public class BrandMappingProfile : Profile
{
    private readonly IFileService _fileService;

    public BrandMappingProfile(IFileService fileService)
    {
        _fileService = fileService;

        CreateMap<RequestBrandDto, Brand>()
            .ForMember(dest => dest.LogoUrl, opt => opt.MapFrom(src => UploadImageAsync(src.Logo!)));
        CreateMap<Brand, RespondBrandDto>().ReverseMap();
    }

    private async Task<string> UploadImageAsync(FileDto file)
    {
        return await _fileService.UploadImage(file);
    }
}