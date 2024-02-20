using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Mappers;

[TestFixture]
    public class BrandMapperTests
    {
        private IMapper _mapper = null!;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BrandMappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Test]
        public void MapToModel_WhenEntityMapped_ReturnsCorrectModel()
        {
            // Arrange
            var entity = Brand.Create("Brand 1", "https://example.com/logo1.png", "Description for Brand 1");

            // Act
            var model = _mapper.Map<BrandEntityModel>(entity);

            // Assert
            That(model, Is.Not.Null);
            That(model.Id, Is.EqualTo(entity.Id.Value));
            That(model.Name, Is.EqualTo(entity.Name));
            That(model.LogoUrl, Is.EqualTo(entity.LogoUrl));
            That(model.Description, Is.EqualTo(entity.Description));
            That(model.CreateDateTime, Is.EqualTo(entity.CreateDateTime));
            That(model.UpdateDateTime, Is.EqualTo(entity.UpdateDateTime));
        }
        
        [Test]
        public void MapToEntity_WhenModelMappedWithoutDependencies_ReturnsCorrectEntity()
        {
            // Arrange
            var model =new BrandEntityModel
            {
                Id = Guid.NewGuid(),
                Name = "Brand 1",
                LogoUrl = "https://example.com/logo1.png",
                Description = "Description for Brand 1",
                CreateDateTime = DateTime.UtcNow,
                UpdateDateTime = DateTime.UtcNow
            };

            // Act
            var entity = _mapper.Map<Brand>(model);
            
            // Assert
            That(entity, Is.Not.Null);
            That(entity.Id.Value, Is.EqualTo(model.Id));
            That(entity.Name, Is.EqualTo(model.Name));
            That(entity.LogoUrl, Is.EqualTo(model.LogoUrl));
            That(entity.Description, Is.EqualTo(model.Description));
            That(entity.CreateDateTime, Is.EqualTo(model.CreateDateTime));
            That(entity.UpdateDateTime, Is.EqualTo(model.UpdateDateTime));
        }
        
        [Test]
        public void MapToModel_WhenEntityMappedWithoutDependencies_ReturnsCorrectModel()
        {
            // Arrange
            var brand = Brand.Create(
                "BrandName",
                "LogoUrl",
                "Description"
            );

            // Act
            var brandEntityModel = _mapper.Map<BrandEntityModel>(brand);
        
            // Assert
            That(brandEntityModel, Is.Not.Null);
            That(brandEntityModel.Id, Is.EqualTo(brand.Id.Value));
            That(brandEntityModel.Name, Is.EqualTo(brand.Name));
            That(brandEntityModel.LogoUrl, Is.EqualTo(brand.LogoUrl));
            That(brandEntityModel.Description, Is.EqualTo(brand.Description));
        }
    }