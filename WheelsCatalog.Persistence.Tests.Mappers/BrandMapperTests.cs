using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Persistence.Mappers;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Mappers;

[TestFixture]
    public class BrandMapperTests
    {
        private IEntityMapper<Brand, BrandEntityModel> _brandMapper = null!;
        private IMapper _mapper = null!;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BrandMappingProfile>();
                cfg.AddProfile<ModelMappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            
            _brandMapper = new BrandMapper(_mapper);
        }

        [Test]
        public void MapToModel_WhenEntityMapped_ReturnsCorrectModel()
        {
            // Arrange
            var entity = Brand.Create("Brand 1", "https://example.com/logo1.png", "Description for Brand 1");

            // Act
            var model = _brandMapper.MapToModel(entity);

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
        public void MapToEntity_WhenModelMapped_ReturnsCorrectEntity()
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
            var entity = _brandMapper.MapToEntity(model);
            
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
        public void MapToModel_WhenEntityMappedWithDependencies_ReturnsCorrectModel()
        {
            // Arrange
            var brand = Brand.Create(
                "BrandName",
                "LogoUrl",
                "Description"
            );

            brand.AddModelId(ModelId.CreateUnique());

            // Act
            var brandEntityModel = _mapper.Map<BrandEntityModel>(brand);
        
            // Assert
            That(brandEntityModel, Is.Not.Null);
            That(brandEntityModel.Id, Is.EqualTo(brand.Id.Value));
            That(brandEntityModel.Id, Is.EqualTo(brand.Id.Value));
            That(brandEntityModel.Name, Is.EqualTo(brand.Name));
            That(brandEntityModel.LogoUrl, Is.EqualTo(brand.LogoUrl));
            That(brandEntityModel.Description, Is.EqualTo(brand.Description));
            
            That(brandEntityModel.Models.Count, Is.EqualTo(1));
            That(brandEntityModel.Models.First().Id, Is.EqualTo(brand.ModelIds.First().Value));
        }
        
        [Test]
        public void MapToModel_WhenEntityMappedWithModels_ReturnsCorrectBrand()
        {
            // Arrange
            var brandId = Guid.NewGuid();
            var testModels = new List<ModelEntityModel>
            {
                new ModelEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Model 1",
                    Description = "Description for Model 1",
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = DateTime.Now,
                    BrandId = brandId
                },
                new  ModelEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Model 2",
                    Description = "Description for Model 2",
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = DateTime.Now,
                    BrandId = brandId
                },
                new ModelEntityModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Model 3",
                    Description = "Description for Model 3",
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = DateTime.Now,
                    BrandId = brandId
                }
            };
                
            var brandEntityModel = new BrandEntityModel
            {
                Id = Guid.NewGuid(),
                Name = "TestBrand",
                LogoUrl = "test_logo_url",
                Description = "Test Description",
                Models = testModels
            };

            // Act
            var brand = _mapper.Map<Brand>(brandEntityModel);

            // Assert
            IsNotNull(brand);
            That(brand.Id.Value, Is.EqualTo(brandEntityModel.Id));
            That(brand.Name, Is.EqualTo(brandEntityModel.Name));
            That(brand.LogoUrl, Is.EqualTo(brandEntityModel.LogoUrl));
            That(brand.Description, Is.EqualTo(brandEntityModel.Description));
            That(brand.ModelIds.Count, Is.EqualTo(brandEntityModel.Models.Count()));
            That(brand.ModelIds.FirstOrDefault()?.Value, Is.EqualTo(brandEntityModel.Models.FirstOrDefault()?.Id));
            IsTrue(brandEntityModel.Models.All(modelEntity =>
                brand.ModelIds.Contains(ModelId.Create(modelEntity.Id))));
        }
    }