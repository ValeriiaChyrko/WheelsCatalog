using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Persistence.Mappers;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Mappers;

[TestFixture]
    public class ColorMapperTests
    {
        private IEntityMapper<ColorEntity, ColorEntityModel> _colorMapper = null!;
        private IMapper _mapper = null!;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ColorEntityMappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            
            _colorMapper = new ColorMapper(_mapper);
        }

        [Test]
        public void MapToModel_WhenEntityMapped_ReturnsCorrectModel()
        {
            // Arrange
            var entity = ColorEntity.Create("Red", "#FF0000");

            // Act
            var model = _colorMapper.MapToModel(entity);

            // Assert
            That(model, Is.Not.Null);
            That(model.Id, Is.EqualTo(entity.Id.Value));
            That(model.Name, Is.EqualTo(entity.Name));
            That(model.HexCode, Is.EqualTo(entity.HexCode));
        }

        [Test]
        public void MapToEntity_WhenModelMapped_ReturnsCorrectEntity()
        {
            // Arrange
            var model = new ColorEntityModel
            {
                Id = Guid.NewGuid(),
                Name = "Red", 
                HexCode = "#FF0000"
            };

            // Act
            var entity = _colorMapper.MapToEntity(model);
            
            // Assert
            That(entity, Is.Not.Null);
            That(entity.Id.Value, Is.EqualTo(model.Id));
            That(entity.Name, Is.EqualTo(model.Name));
            That(entity.HexCode, Is.EqualTo(model.HexCode));
        }
    }