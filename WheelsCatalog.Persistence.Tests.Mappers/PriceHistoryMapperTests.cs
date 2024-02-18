using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Domain.PriceHistoryAggregate.ValueObjects;
using WheelsCatalog.Persistence.Mappers;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Mappers;

[TestFixture]
    public class PriceHistoryMapperTests
    {
        private IEntityMapper<PriceHistory, PriceHistoryEntityModel> _priceHistoriesMapper = null!;
        private IMapper _mapper = null!;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<PriceHistoryMappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            
            _priceHistoriesMapper = new PriceHistoryMapper(_mapper);
        }

        [Test]
        public void MapToModel_WhenEntityMapped_ReturnsCorrectModel()
        {
            // Arrange
            var entity = PriceHistory.Create(1000.00, new DateTime(2023, 1, 1), CurrencyId.CreateUnique(), CarId.CreateUnique());

            // Act
            var model = _priceHistoriesMapper.MapToModel(entity);

            // Assert
            That(model, Is.Not.Null);
            That(model.Id, Is.EqualTo(entity.Id.Value));
            That(model.Price, Is.EqualTo(entity.Price));
            That(model.StartDate, Is.EqualTo(entity.StartDate));
            That(model.CurrencyId, Is.EqualTo(entity.CurrencyId.Value));
            That(model.CarId, Is.EqualTo(entity.CarId.Value));
            That(model.CreateDateTime, Is.EqualTo(entity.CreateDateTime));
        }

        [Test]
        public void MapToEntity_WhenModelMapped_ReturnsCorrectEntity()
        {
            // Arrange
            var model = new PriceHistoryEntityModel
            {
                Id = Guid.NewGuid(),
                Price = 1500.00, 
                StartDate = new DateTime(2023, 2, 1), 
                CurrencyId = CurrencyId.CreateUnique().Value
            };

            // Act
            var entity = _priceHistoriesMapper.MapToEntity(model);
            
            // Assert
            That(entity, Is.Not.Null);
            That(entity.Id.Value, Is.EqualTo(model.Id));
            That(model.Price, Is.EqualTo(entity.Price));
            That(model.StartDate, Is.EqualTo(entity.StartDate));
            That(model.CurrencyId, Is.EqualTo(entity.CurrencyId.Value));
            That(model.CarId, Is.EqualTo(entity.CarId.Value));
            That(model.CreateDateTime, Is.EqualTo(entity.CreateDateTime));
        }
    }