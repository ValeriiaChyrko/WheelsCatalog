using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Mappers;

[TestFixture]
    public class CarPhotoMapperTests
    {
        private IMapper _mapper = null!;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarPhotoEntityMappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Test]
        public void MapToModel_WhenEntityMapped_ReturnsCorrectModel()
        {
            // Arrange
            var entity = CarPhotoEntity.Create("https://example.com/photo.png", CarId.CreateUnique());

            // Act
            var model = _mapper.Map<CarPhotoEntityModel>(entity);

            // Assert
            That(model, Is.Not.Null);
            That(model.Id, Is.EqualTo(entity.Id.Value));
            That(model.PhotoUrl, Is.EqualTo(entity.PhotoUrl));
            That(model.CarId, Is.EqualTo(entity.CarId.Value));
        }

        [Test]
        public void MapToEntity_WhenModelMapped_ReturnsCorrectEntity()
        {
            // Arrange
            var model = new CarPhotoEntityModel
            {
                Id = Guid.NewGuid(),
                PhotoUrl = "https://example.com/photo.png",
                CarId = CarId.CreateUnique().Value
            };

            // Act
            var entity = _mapper.Map<CarPhotoEntity>(model);
            
            // Assert
            That(entity, Is.Not.Null);
            That(entity.Id.Value, Is.EqualTo(model.Id));
            That(entity.PhotoUrl, Is.EqualTo(model.PhotoUrl));
            That(entity.CarId.Value, Is.EqualTo(model.CarId));
        }
    }