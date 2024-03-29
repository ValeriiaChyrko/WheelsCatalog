using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using WheelsCatalog.Domain.ColorAggregate;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Repositories;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Repositories;

[TestFixture]
public class ColorRepositoryTests
{
    private WheelsCatalogDbContext _dbContext = null!;
    private ColorRepository _colorRepository = null!;
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<WheelsCatalogDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<ColorEntityModelMappingProfile>();
        });

        _mapper = mapperConfig.CreateMapper();

        _dbContext = new WheelsCatalogDbContext(options);
        _colorRepository = new ColorRepository(_dbContext, _mapper);
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
        var entities = new List<Color>
        {
            Color.Create("Red", "#FF0000"),
            Color.Create("Green", "#00FF00"),
            Color.Create("Blue", "#0000FF")
        };

        var cancellationToken = new CancellationToken();
        await _colorRepository.AddRangeAsync(entities, cancellationToken);

        // Act
        var result = await _colorRepository.ListAsync(cancellationToken);

        // Assert
        IsNotNull(result);
        That(result.Count, Is.EqualTo(entities.Count));
        That(result.FirstOrDefault()?.Id.Value, Is.EqualTo(entities.FirstOrDefault()?.Id.Value));
        That(result.FirstOrDefault()?.Name, Is.EqualTo(entities.FirstOrDefault()?.Name));
        That(result.FirstOrDefault()?.HexCode, Is.EqualTo(entities.FirstOrDefault()?.HexCode));
    }

    [Test]
    public async Task AddAsync_WhenEntityAdded_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Color.Create("Red", "#FF0000");
        var cancellationToken = new CancellationToken();

        // Act
        var result = await _colorRepository.AddAsync(entityToAdd, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Name, Is.EqualTo(entityToAdd.Name));
        That(result.HexCode, Is.EqualTo(entityToAdd.HexCode));
    }

    [Test]
    public async Task UpdateAsync_WhenEntityUpdated_ReturnsUpdatedEntity()
    {
        // Arrange
        var entity = Color.Create("Red", "#FF0000");
        var cancellationToken = new CancellationToken();
        await _colorRepository.AddAsync(entity, cancellationToken);

        // Act
        var updatedName = "Updated Red";
        var updatedHexCode = "#FF0011";

        var entityFromDatabase = await _colorRepository.GetByIdAsync(entity.Id.Value, cancellationToken);
        That(entityFromDatabase, Is.Not.Null);

        entityFromDatabase!.Update(updatedName, updatedHexCode);
        var result = await _colorRepository.UpdateAsync(entityFromDatabase, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Name, Is.EqualTo(updatedName));
        That(result.HexCode, Is.EqualTo(updatedHexCode));
    }

    [Test]
    public async Task DeleteAsync_WhenEntityDeleted_ReturnsTrue()
    {
        // Arrange
        var entity = Color.Create("Red", "#FF0000");
        var cancellationToken = new CancellationToken();
        await _colorRepository.AddAsync(entity, cancellationToken);

        // Act
        var result = await _colorRepository.DeleteAsync(entity, cancellationToken);

        // Assert
        IsTrue(result > 0);
    }

    [Test]
    public async Task GetByIdAsync_WhenEntityExists_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Color.Create("Red", "#FF0000");
        var cancellationToken = new CancellationToken();
        var entityModel = await _colorRepository.AddAsync(entityToAdd, cancellationToken);

        // Act
        var result = await _colorRepository.GetByIdAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsNotNull(result);
        That(result!.Id.Value, Is.EqualTo(entityModel.Id.Value));
        That(result.Name, Is.EqualTo(entityModel.Name));
        That(result.HexCode, Is.EqualTo(entityModel.HexCode));
    }
}