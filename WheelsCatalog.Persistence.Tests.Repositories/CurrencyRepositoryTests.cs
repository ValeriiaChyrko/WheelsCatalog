using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using WheelsCatalog.Domain.CurrencyAggregate;
using WheelsCatalog.Persistence.Interceptors;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Repositories;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests;

[TestFixture]
public class CurrencyRepositoryTests
{
    private WheelsCatalogDbContext _dbContext = null!;
    private CurrencyRepository _currencyRepository = null!;
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
            cfg.AddProfile<CurrencyMappingProfile>();
        });

        _mapper = mapperConfig.CreateMapper();

        _dbContext = new WheelsCatalogDbContext(options, interceptor);
        _currencyRepository = new CurrencyRepository(_dbContext, _mapper);
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
        var entities = new List<Currency>
        {
            Currency.Create("USD"),
            Currency.Create("UAH"),
            Currency.Create("EU")
        };

        var cancellationToken = new CancellationToken();
        await _currencyRepository.AddRangeAsync(entities, cancellationToken);

        // Act
        var result = await _currencyRepository.ListAsync(cancellationToken);

        // Assert
        IsNotNull(result);
        That(result.Count, Is.EqualTo(entities.Count));
        That(result.FirstOrDefault()?.Id.Value, Is.EqualTo(entities.FirstOrDefault()?.Id.Value));
        That(result.FirstOrDefault()?.Acronym, Is.EqualTo(entities.FirstOrDefault()?.Acronym));
    }

    [Test]
    public async Task AddAsync_WhenEntityAdded_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Currency.Create("USD");
        var cancellationToken = new CancellationToken();

        // Act
        var result = await _currencyRepository.AddAsync(entityToAdd, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Acronym, Is.EqualTo(entityToAdd.Acronym));
    }

    [Test]
    public async Task UpdateAsync_WhenEntityUpdated_ReturnsUpdatedEntity()
    {
        // Arrange
        var entity = Currency.Create("USD");
        var cancellationToken = new CancellationToken();
        await _currencyRepository.AddAsync(entity, cancellationToken);

        // Act
        var updatedAcronym = "UAH";

        var entityFromDatabase = await _currencyRepository.GetByIdAsync(entity.Id.Value, cancellationToken);
        That(entityFromDatabase, Is.Not.Null);

        entityFromDatabase!.Update(updatedAcronym);
        var result = await _currencyRepository.UpdateAsync(entityFromDatabase, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Acronym, Is.EqualTo(updatedAcronym));
    }

    [Test]
    public async Task DeleteAsync_WhenEntityDeleted_ReturnsTrue()
    {
        // Arrange
        var entity = Currency.Create("USD");
        var cancellationToken = new CancellationToken();
        await _currencyRepository.AddAsync(entity, cancellationToken);

        // Act
        var result = await _currencyRepository.DeleteAsync(entity, cancellationToken);

        // Assert
        IsTrue(result > 0);
    }

    [Test]
    public async Task GetByIdAsync_WhenEntityExists_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Currency.Create("USD");
        var cancellationToken = new CancellationToken();
        var entityModel = await _currencyRepository.AddAsync(entityToAdd, cancellationToken);

        // Act
        var result = await _currencyRepository.GetByIdAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsNotNull(result);
        That(result!.Id.Value, Is.EqualTo(entityModel.Id.Value));
        That(result.Acronym, Is.EqualTo(entityModel.Acronym));
    }
}