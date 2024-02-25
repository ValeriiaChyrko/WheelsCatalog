using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using WheelsCatalog.Domain.BrandAggregate;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Repositories;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Repositories;

[TestFixture]
public class BrandRepositoryTests
{
    private WheelsCatalogDbContext _dbContext = null!;
    private BrandRepository _brandRepository = null!;
    private IMapper _mapper = null!;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<WheelsCatalogDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<BrandEntityModelMappingProfile>();
            cfg.AddProfile<ModelEntityModelMappingProfile>();
        });

        _mapper = mapperConfig.CreateMapper();

        _dbContext = new WheelsCatalogDbContext(options);
        _brandRepository = new BrandRepository(_dbContext, _mapper);
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
        var entities = new List<Brand>
        {
            Brand.Create("Brand 1", "https://example.com/logo1.png", "Description for Brand 1"),
            Brand.Create("Brand 2", "https://example.com/logo2.png", "Description for Brand 2"),
            Brand.Create("Brand 3", "https://example.com/logo3.png", "Description for Brand 3")
        };

        var cancellationToken = new CancellationToken();
        await _brandRepository.AddRangeAsync(entities, cancellationToken);

        // Act
        var result = await _brandRepository.ListAsync(cancellationToken);

        // Assert
        IsNotNull(result);
        That(result.Count, Is.EqualTo(entities.Count));
        That(result.FirstOrDefault()?.Id.Value, Is.EqualTo(entities.FirstOrDefault()?.Id.Value));
        That(result.FirstOrDefault()?.Name, Is.EqualTo(entities.FirstOrDefault()?.Name));
        That(result.FirstOrDefault()?.LogoUrl, Is.EqualTo(entities.FirstOrDefault()?.LogoUrl));
        That(result.FirstOrDefault()?.Description, Is.EqualTo(entities.FirstOrDefault()?.Description));
        That(result.FirstOrDefault()?.CreateDateTime, Is.EqualTo(entities.FirstOrDefault()?.CreateDateTime));
        That(result.FirstOrDefault()?.UpdateDateTime, Is.EqualTo(entities.FirstOrDefault()?.UpdateDateTime));
    }

    [Test]
    public async Task AddAsync_WhenEntityAdded_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Brand.Create("Brand 1", "https://example.com/logo1.png", "Description for Brand 1");
        var cancellationToken = new CancellationToken();

        // Act
        var result = await _brandRepository.AddAsync(entityToAdd, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Name, Is.EqualTo(entityToAdd.Name));
        That(result.LogoUrl, Is.EqualTo(entityToAdd.LogoUrl));
        That(result.Description, Is.EqualTo(entityToAdd.Description));
        That(result.CreateDateTime, Is.EqualTo(entityToAdd.CreateDateTime));
        That(result.UpdateDateTime, Is.EqualTo(entityToAdd.UpdateDateTime));
    }

    [Test]
    public async Task UpdateAsync_WhenEntityUpdated_ReturnsUpdatedEntity()
    {
        // Arrange
        var entity = Brand.Create("Brand 1", "https://example.com/logo1.png", "Description for Brand 1");
        var cancellationToken = new CancellationToken();
        await _brandRepository.AddAsync(entity, cancellationToken);

        // Act
        var updatedName = "Updated Brand Name";
        var updatedLogoUrl = "https://example.com/updated_logo.png";
        var updatedDescription = "Updated description";

        var entityFromDatabase = await _brandRepository.GetByIdAsync(entity.Id.Value, cancellationToken);
        That(entityFromDatabase, Is.Not.Null);

        entityFromDatabase!.Update(updatedName, updatedLogoUrl, updatedDescription);
        var result = await _brandRepository.UpdateAsync(entityFromDatabase, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Name, Is.EqualTo(updatedName));
        That(result.LogoUrl, Is.EqualTo(updatedLogoUrl));
        That(result.Description, Is.EqualTo(updatedDescription));
    }

    [Test]
    public async Task DeleteAsync_WhenEntityDeleted_ReturnsTrue()
    {
        // Arrange
        var entity = Brand.Create("Brand to delete", "https://example.com/logo.png", "Description for Brand to delete");
        var cancellationToken = new CancellationToken();
        await _brandRepository.AddAsync(entity, cancellationToken);

        // Act
        var result = await _brandRepository.DeleteAsync(entity, cancellationToken);

        // Assert
        IsTrue(result > 0);
    }

    [Test]
    public async Task GetByIdAsync_WhenEntityExists_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Brand.Create("Brand 1", "https://example.com/logo1.png", "Description for Brand 1");
        var cancellationToken = new CancellationToken();
        var entityModel = await _brandRepository.AddAsync(entityToAdd, cancellationToken);

        // Act
        var result = await _brandRepository.GetByIdAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsNotNull(result);
        That(result!.Id.Value, Is.EqualTo(entityModel.Id.Value));
        That(result.Name, Is.EqualTo(entityModel.Name));
        That(result.LogoUrl, Is.EqualTo(entityModel.LogoUrl));
        That(result.Description, Is.EqualTo(entityModel.Description));
        That(result.CreateDateTime, Is.EqualTo(entityModel.CreateDateTime));
        That(result.UpdateDateTime, Is.EqualTo(entityModel.UpdateDateTime));
    }
}