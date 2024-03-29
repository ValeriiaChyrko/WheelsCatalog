using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using WheelsCatalog.Domain.CarAggregate;
using WheelsCatalog.Domain.ColorAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate.ValueObjects;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Repositories;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Repositories;

[TestFixture]
public class CarRepositoryTests
{
    private WheelsCatalogDbContext _dbContext = null!;
    private CarRepository _carRepository = null!;
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<WheelsCatalogDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<CarEntityModelMappingProfile>();
        });

        _mapper = mapperConfig.CreateMapper();

        _dbContext = new WheelsCatalogDbContext(options);
        _carRepository = new CarRepository(_dbContext, _mapper);
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
        var entities = new List<Car>
        {
            Car.Create(
            engineVolume: 2000,
            description: "Sedan",
            colorId: ColorId.CreateUnique(),
            modelId: ModelId.CreateUnique()
            ),
            Car.Create(
            engineVolume: 1800,
            description: "SUV",
            colorId: ColorId.CreateUnique(),
            modelId: ModelId.CreateUnique()
            ),
            Car.Create(
            engineVolume: 2500,
            description: null,
            colorId: ColorId.CreateUnique(),
            modelId: ModelId.CreateUnique()
            )
        };

        var cancellationToken = new CancellationToken();
        await _carRepository.AddRangeAsync(entities, cancellationToken);

        // Act
        var result = await _carRepository.ListAsync(cancellationToken);

        // Assert
        IsNotNull(result);
        That(result.Count, Is.EqualTo(entities.Count));
        That(result.FirstOrDefault()?.Id.Value, Is.EqualTo(entities.FirstOrDefault()?.Id.Value));
        That(result.FirstOrDefault()?.ColorId, Is.EqualTo(entities.FirstOrDefault()?.ColorId));
        That(result.FirstOrDefault()?.ModelId, Is.EqualTo(entities.FirstOrDefault()?.ModelId));
        That(result.FirstOrDefault()?.EngineVolume, Is.EqualTo(entities.FirstOrDefault()?.EngineVolume));
        That(result.FirstOrDefault()?.Description, Is.EqualTo(entities.FirstOrDefault()?.Description));
        That(result.FirstOrDefault()?.CreateDateTime, Is.EqualTo(entities.FirstOrDefault()?.CreateDateTime));
        That(result.FirstOrDefault()?.UpdateDateTime, Is.EqualTo(entities.FirstOrDefault()?.UpdateDateTime));
    }

    [Test]
    public async Task AddAsync_WhenEntityAdded_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Car.Create(
            engineVolume: 2000,
            description: "Sedan",
            colorId: ColorId.CreateUnique(),
            modelId: ModelId.CreateUnique()
        );
        
        var cancellationToken = new CancellationToken();

        // Act
        var result = await _carRepository.AddAsync(entityToAdd, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.EngineVolume, Is.EqualTo(entityToAdd.EngineVolume));
        That(result.Description, Is.EqualTo(entityToAdd.Description));
        That(result.ColorId.Value, Is.EqualTo(entityToAdd.ColorId.Value));
        That(result.ModelId.Value, Is.EqualTo(entityToAdd.ModelId.Value));
        That(result.CreateDateTime, Is.EqualTo(entityToAdd.CreateDateTime));
        That(result.UpdateDateTime, Is.EqualTo(entityToAdd.UpdateDateTime));
    }

    [Test]
    public async Task UpdateAsync_WhenEntityUpdated_ReturnsUpdatedEntity()
    {
        // Arrange
        var entity = Car.Create(
            engineVolume: 2000,
            description: "Sedan",
            colorId: ColorId.CreateUnique(),
            modelId: ModelId.CreateUnique()
        );
        var cancellationToken = new CancellationToken();
        await _carRepository.AddAsync(entity, cancellationToken);

        // Act
        var updatedEngineVolume = 1570;
        var updatedDescription = "Updated Sedan";
        var updatedColorId = ColorId.CreateUnique();
        var updatedModelId = ModelId.CreateUnique();

        var entityFromDatabase = await _carRepository.GetByIdAsync(entity.Id.Value, cancellationToken);
        That(entityFromDatabase, Is.Not.Null);

        entityFromDatabase!.Update(updatedEngineVolume, updatedDescription, updatedColorId, updatedModelId);
        var result = await _carRepository.UpdateAsync(entityFromDatabase, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.EngineVolume, Is.EqualTo(updatedEngineVolume));
        That(result.Description, Is.EqualTo(updatedDescription));
        That(result.ColorId.Value, Is.EqualTo(updatedColorId.Value));
        That(result.ModelId.Value, Is.EqualTo(updatedModelId.Value));
        That(result.CreateDateTime, Is.EqualTo(entity.CreateDateTime));
        That(result.UpdateDateTime, Is.Not.EqualTo(entity.UpdateDateTime));
    }

    [Test]
    public async Task DeleteAsync_WhenEntityDeleted_ReturnsTrue()
    {
        // Arrange
        var entity = Car.Create(
            engineVolume: 2000,
            description: "Sedan",
            colorId: ColorId.CreateUnique(),
            modelId: ModelId.CreateUnique()
        );
        var cancellationToken = new CancellationToken();
        await _carRepository.AddAsync(entity, cancellationToken);

        // Act
        var result = await _carRepository.DeleteAsync(entity, cancellationToken);

        // Assert
        IsTrue(result > 0);
    }

    [Test]
    public async Task GetByIdAsync_WhenEntityExists_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Car.Create(
            engineVolume: 2000,
            description: "Sedan",
            colorId: ColorId.CreateUnique(),
            modelId: ModelId.CreateUnique()
        );
        var cancellationToken = new CancellationToken();
        var entityModel = await _carRepository.AddAsync(entityToAdd, cancellationToken);

        // Act
        var result = await _carRepository.GetByIdAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsNotNull(result);
        That(result!.Id.Value, Is.EqualTo(entityModel.Id.Value));
        That(result.EngineVolume, Is.EqualTo(entityToAdd.EngineVolume));
        That(result.ColorId.Value, Is.EqualTo(entityToAdd.ColorId.Value));
        That(result.ModelId.Value, Is.EqualTo(entityToAdd.ModelId.Value));
        That(result.Description, Is.EqualTo(entityModel.Description));
        That(result.CreateDateTime, Is.EqualTo(entityModel.CreateDateTime));
        That(result.UpdateDateTime, Is.EqualTo(entityModel.UpdateDateTime));
    }
}