using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using WheelsCatalog.Domain.CarAggregate.Entities;
using WheelsCatalog.Domain.CarAggregate.ValueObjects;
using WheelsCatalog.Persistence.Interceptors;
using WheelsCatalog.Persistence.Mappers;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using WheelsCatalog.Persistence.Repositories;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests;

[TestFixture]
public class CarPhotoRepositoryTests
{
    private WheelsCatalogDbContext _dbContext = null!;
    private CarPhotoRepository _carPhotoRepository = null!;
    private IEntityMapper<CarPhotoEntity, CarPhotoEntityModel> _carPhotoMapper = null!;
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
            cfg.AddProfile<CarPhotoEntityMappingProfile>();
        });

        _mapper = mapperConfig.CreateMapper();
        _carPhotoMapper = new CarPhotoMapper(_mapper);

        _dbContext = new WheelsCatalogDbContext(options, interceptor);
        _carPhotoRepository = new CarPhotoRepository(_dbContext, _carPhotoMapper);
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
        var carId = CarId.CreateUnique();
        var entities = new List<CarPhotoEntity>
        {
            CarPhotoEntity.Create("test1_logo_url", carId),
            CarPhotoEntity.Create("test2_logo_url", carId),
            CarPhotoEntity.Create("test3_logo_url", carId)
        };

        var cancellationToken = new CancellationToken();
        await _carPhotoRepository.AddRangeAsync(entities, cancellationToken);

        // Act
        var result = await _carPhotoRepository.ListAsync(cancellationToken);

        // Assert
        IsNotNull(result);
        That(result.Count, Is.EqualTo(entities.Count));
        That(result.FirstOrDefault()?.Id.Value, Is.EqualTo(entities.FirstOrDefault()?.Id.Value));
        That(result.FirstOrDefault()?.PhotoUrl, Is.EqualTo(entities.FirstOrDefault()?.PhotoUrl));
        That(result.FirstOrDefault()?.CarId, Is.EqualTo(entities.FirstOrDefault()?.CarId));
    }

    [Test]
    public async Task AddAsync_WhenEntityAdded_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = CarPhotoEntity.Create("test1_logo_url", CarId.CreateUnique());
        var cancellationToken = new CancellationToken();

        // Act
        var result = await _carPhotoRepository.AddAsync(entityToAdd, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.PhotoUrl, Is.EqualTo(entityToAdd.PhotoUrl));
        That(result.CarId, Is.EqualTo(entityToAdd.CarId));
    }

    [Test]
    public async Task UpdateAsync_WhenEntityUpdated_ReturnsUpdatedEntity()
    {
        // Arrange
        var entity = CarPhotoEntity.Create("test1_logo_url", CarId.CreateUnique());
        var cancellationToken = new CancellationToken();
        await _carPhotoRepository.AddAsync(entity, cancellationToken);

        // Act
        var updatedUrl = "updated_test_logo_url";
        var updatedCarId = CarId.CreateUnique();

        var entityFromDatabase = await _carPhotoRepository.GetByIdAsync(entity.Id.Value, cancellationToken);
        That(entityFromDatabase, Is.Not.Null);

        entityFromDatabase!.Update(updatedUrl, updatedCarId);
        var result = await _carPhotoRepository.UpdateAsync(entityFromDatabase, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.PhotoUrl, Is.EqualTo(updatedUrl));
        That(result.CarId, Is.EqualTo(updatedCarId));
    }

    [Test]
    public async Task DeleteAsync_WhenEntityDeleted_ReturnsTrue()
    {
        // Arrange
        var entity = CarPhotoEntity.Create("test1_logo_url", CarId.CreateUnique());
        var cancellationToken = new CancellationToken();
        await _carPhotoRepository.AddAsync(entity, cancellationToken);

        // Act
        var result = await _carPhotoRepository.DeleteAsync(entity, cancellationToken);

        // Assert
        IsTrue(result > 0);
    }

    [Test]
    public async Task GetByIdAsync_WhenEntityExists_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = CarPhotoEntity.Create("test1_logo_url", CarId.CreateUnique());
        var cancellationToken = new CancellationToken();
        var entityModel = await _carPhotoRepository.AddAsync(entityToAdd, cancellationToken);

        // Act
        var result = await _carPhotoRepository.GetByIdAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsNotNull(result);
        That(result!.Id.Value, Is.EqualTo(entityModel.Id.Value));
        That(result.PhotoUrl, Is.EqualTo(entityModel.PhotoUrl));
        That(result.CarId, Is.EqualTo(entityModel.CarId));
    }

    [Test]
    public async Task IsExistAsync_WhenEntityExists_ReturnsTrue()
    {
        // Arrange
        var entityToAdd = CarPhotoEntity.Create("test1_logo_url", CarId.CreateUnique());
        var cancellationToken = new CancellationToken();
        await _carPhotoRepository.AddAsync(entityToAdd, cancellationToken);

        // Act
        var result = await _carPhotoRepository.IsExistAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsTrue(result);
    }

    [Test]
    public async Task IsExistAsync_WhenEntityDoesNotExist_ReturnsFalse()
    {
        // Arrange
        var entityToAdd = CarPhotoEntity.Create("test1_logo_url", CarId.CreateUnique());
        var cancellationToken = new CancellationToken();

        // Act
        var result = await _carPhotoRepository.IsExistAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsFalse(result);
    }
}