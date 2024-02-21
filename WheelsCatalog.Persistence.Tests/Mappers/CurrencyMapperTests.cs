using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Domain.CurrencyAggregate;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Mappers;

[TestFixture]
    public class CurrencyMapperTests
    {
        private IMapper _mapper = null!;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CurrencyEntityModelMappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Test]
        public void MapToModel_WhenEntityMapped_ReturnsCorrectModel()
        {
            // Arrange
            var entity = Currency.Create("USD");

            // Act
            var model = _mapper.Map<CurrencyEntityModel>(entity);

            // Assert
            That(model, Is.Not.Null);
            That(model.Id, Is.EqualTo(entity.Id.Value));
            That(model.Acronym, Is.EqualTo(entity.Acronym));
        }

        [Test]
        public void MapToEntity_WhenModelMapped_ReturnsCorrectEntity()
        {
            // Arrange
            var model = new CurrencyEntityModel
            {
                Id = Guid.NewGuid(),
                Acronym = "USD"
            };

            // Act
            var entity = _mapper.Map<Currency>(model);
            
            // Assert
            That(entity, Is.Not.Null);
            That(entity.Id.Value, Is.EqualTo(model.Id));
            That(entity.Acronym, Is.EqualTo(model.Acronym));
        }
    }