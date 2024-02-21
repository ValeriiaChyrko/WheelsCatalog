using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Domain.CurrencyAggregate.ValueObjects;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Persistence.Interceptors;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Repositories;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Repositories;

[TestFixture]
public class PriceHistoryRepositoryTests
{
    private WheelsCatalogDbContext _dbContext = null!;
    private PriceHistoryRepository _priceHistoryRepository = null!;
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<WheelsCatalogDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        var mediatorMock = new Mock<IMediator>();
        var interceptor = new PublishDomainEventsInterceptor(mediatorMock.Object);

        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<PriceHistoryEntityModelMappingProfile>();
        });

        _mapper = mapperConfig.CreateMapper();

        _dbContext = new WheelsCatalogDbContext(options, interceptor);
        _priceHistoryRepository = new PriceHistoryRepository(_dbContext, _mapper);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    [Test]
    public async Task ListAsync_WithPredicate_ReturnsFilteredCollection()
    {
        // Arrange
        var currencyId = CurrencyId.CreateUnique();
        var carId = CarId.CreateUnique();
        var entities = new List<PriceHistory>
        {
            PriceHistory.Create(1000.00, new DateTime(2023, 1, 1), currencyId, carId),
            PriceHistory.Create(1500.00, new DateTime(2023, 2, 1), currencyId, carId),
            PriceHistory.Create(2000.00, new DateTime(2024, 2, 1), currencyId, carId)
        };

        var cancellationToken = new CancellationToken();
        await _priceHistoryRepository.AddRangeAsync(entities, cancellationToken);

        // Act
        var result = await _priceHistoryRepository.ListAsync(cancellationToken);

        // Assert
        IsNotNull(result);
        That(result.Count, Is.EqualTo(entities.Count));
        That(result.FirstOrDefault()?.Id.Value, Is.EqualTo(entities.FirstOrDefault()?.Id.Value));
        That(result.FirstOrDefault()?.Price, Is.EqualTo(entities.FirstOrDefault()?.Price));
        That(result.FirstOrDefault()?.StartDate, Is.EqualTo(entities.FirstOrDefault()?.StartDate));
        That(result.FirstOrDefault()?.CurrencyId.Value, Is.EqualTo(entities.FirstOrDefault()?.CurrencyId.Value));
        That(result.FirstOrDefault()?.CarId.Value, Is.EqualTo(entities.FirstOrDefault()?.CarId.Value));
        That(result.FirstOrDefault()?.CreateDateTime, Is.EqualTo(entities.FirstOrDefault()?.CreateDateTime));
        That(result.FirstOrDefault()?.UpdateDateTime, Is.EqualTo(entities.FirstOrDefault()?.UpdateDateTime));
    }

    [Test]
    public async Task AddAsync_WhenEntityAdded_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = PriceHistory.Create(1000.00, new DateTime(2023, 2, 1), CurrencyId.CreateUnique(), CarId.CreateUnique());
        var cancellationToken = new CancellationToken();

        // Act
        var result = await _priceHistoryRepository.AddAsync(entityToAdd, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Price, Is.EqualTo(entityToAdd.Price));
        That(result.StartDate, Is.EqualTo(entityToAdd.StartDate));
        That(result.CurrencyId.Value, Is.EqualTo(entityToAdd.CurrencyId.Value));
        That(result.CarId.Value, Is.EqualTo(entityToAdd.CarId.Value));
        That(result.CreateDateTime, Is.EqualTo(entityToAdd.CreateDateTime));
        That(result.UpdateDateTime, Is.EqualTo(entityToAdd.UpdateDateTime));
    }

    [Test]
    public async Task UpdateAsync_WhenEntityUpdated_ReturnsUpdatedEntity()
    {
        // Arrange
        var entity = PriceHistory.Create(1000.00, new DateTime(2023, 2, 17), CurrencyId.CreateUnique(), CarId.CreateUnique());
        var cancellationToken = new CancellationToken();
        await _priceHistoryRepository.AddAsync(entity, cancellationToken);

        // Act
        var updatedPrice = 1500;
        var updatedStartDate = DateTime.Now;
        var updatedCurrencyId = CurrencyId.CreateUnique();
        var updatedCarId = CarId.CreateUnique();

        var entityFromDatabase = await _priceHistoryRepository.GetByIdAsync(entity.Id.Value, cancellationToken);
        That(entityFromDatabase, Is.Not.Null);

        entityFromDatabase!.Update(updatedPrice, updatedStartDate, updatedCurrencyId, updatedCarId);
        var result = await _priceHistoryRepository.UpdateAsync(entityFromDatabase, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Price, Is.EqualTo(updatedPrice));
        That(result.StartDate, Is.EqualTo(updatedStartDate));
        That(result.CurrencyId.Value, Is.EqualTo(updatedCurrencyId.Value));
        That(result.CarId.Value, Is.EqualTo(updatedCarId.Value));
        That(result.CreateDateTime, Is.EqualTo(entity.CreateDateTime));
        That(result.UpdateDateTime, Is.Not.EqualTo(entity.UpdateDateTime));
    }

    [Test]
    public async Task DeleteAsync_WhenEntityDeleted_ReturnsTrue()
    {
        // Arrange
        var entity =  PriceHistory.Create(1000.00, new DateTime(2023, 2, 17), CurrencyId.CreateUnique(), CarId.CreateUnique());
        var cancellationToken = new CancellationToken();
        await _priceHistoryRepository.AddAsync(entity, cancellationToken);

        // Act
        var result = await _priceHistoryRepository.DeleteAsync(entity, cancellationToken);

        // Assert
        IsTrue(result > 0);
    }

    [Test]
    public async Task GetByIdAsync_WhenEntityExists_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = PriceHistory.Create(1000.00, new DateTime(2023, 2, 17), CurrencyId.CreateUnique(), CarId.CreateUnique());
        var cancellationToken = new CancellationToken();
        var entityModel = await _priceHistoryRepository.AddAsync(entityToAdd, cancellationToken);

        // Act
        var result = await _priceHistoryRepository.GetByIdAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsNotNull(result);
        That(result!.Id.Value, Is.EqualTo(entityModel.Id.Value));
        That(result.Price, Is.EqualTo(entityToAdd.Price));
        That(result.StartDate, Is.EqualTo(entityToAdd.StartDate));
        That(result.CurrencyId.Value, Is.EqualTo(entityToAdd.CurrencyId.Value));
        That(result.CarId.Value, Is.EqualTo(entityToAdd.CarId.Value));
        That(result.CreateDateTime, Is.EqualTo(entityToAdd.CreateDateTime));
        That(result.UpdateDateTime, Is.EqualTo(entityToAdd.UpdateDateTime));
    }
}