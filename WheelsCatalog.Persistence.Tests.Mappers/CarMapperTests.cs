using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Persistence.Mappers;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Mappers;

[TestFixture]
    public class CarMapperTests
    {
        private IEntityMapper<Car, CarEntityModel> _carMapper = null!;
        private IMapper _mapper = null!;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarMappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            
            _carMapper = new CarMapper(_mapper);
        }

        [Test]
        public void MapToModel_WhenEntityMapped_ReturnsCorrectModel()
        {
            // Arrange
            var entity = Car.Create(
                engineVolume: 2500,
                description: "Convertible",
                colorId: ColorId.CreateUnique(),
                brandId: BrandId.CreateUnique(),
                modelId: ModelId.CreateUnique()
            );

            // Act
            var model = _carMapper.MapToModel(entity);

            // Assert
            That(model, Is.Not.Null);
            That(model.Id, Is.EqualTo(entity.Id.Value));
            That(model.EngineVolume, Is.EqualTo(entity.EngineVolume));
            That(model.Description, Is.EqualTo(entity.Description));
            That(model.ColorId, Is.EqualTo(entity.ColorId.Value));
            That(model.BrandId, Is.EqualTo(entity.BrandId.Value));
            That(model.ModelId, Is.EqualTo(entity.ModelId.Value));
            IsTrue(DateTime.Equals(model.CreateDateTime, entity.CreateDateTime));
            IsTrue(DateTime.Equals(model.UpdateDateTime, entity.UpdateDateTime));
        }

        [Test]
        public void MapToEntity_WhenModelMapped_ReturnsCorrectEntity()
        {
            // Arrange
            var model = new CarEntityModel
            {
                Id = Guid.NewGuid(),
                EngineVolume = 1800,
                Description = "SUV",
                ColorId = ColorId.CreateUnique().Value,
                BrandId = BrandId.CreateUnique().Value,
                ModelId = ModelId.CreateUnique().Value
            };

            // Act
            var entity = _carMapper.MapToEntity(model);
            
            // Assert
            That(entity, Is.Not.Null);
            That(entity.Id.Value, Is.EqualTo(model.Id));
            That(model.EngineVolume, Is.EqualTo(entity.EngineVolume));
            That(model.Description, Is.EqualTo(entity.Description));
            That(model.ColorId, Is.EqualTo(entity.ColorId.Value));
            That(model.BrandId, Is.EqualTo(entity.BrandId.Value));
            That(model.ModelId, Is.EqualTo(entity.ModelId.Value));
            IsTrue(DateTime.Equals(model.CreateDateTime, entity.CreateDateTime));
            IsTrue(DateTime.Equals(model.UpdateDateTime, entity.UpdateDateTime));
        }
    }