using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Repositories;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Repositories;

[TestFixture]
public class ModelRepositoryTests
{
    private WheelsCatalogDbContext _dbContext = null!;
    private ModelRepository _modelRepository = null!;
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
        _modelRepository = new ModelRepository(_dbContext, _mapper);
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
        var brandId = BrandId.CreateUnique();
        var entities = new List<Model>
        {
            Model.Create("ModelName1", "Description for Model 1", brandId),
            Model.Create("ModelName2", null, brandId),
            Model.Create("ModelName3", "Description for Model 3", brandId)
        };

        var cancellationToken = new CancellationToken();
        await _modelRepository.AddRangeAsync(entities, cancellationToken);

        // Act
        var result = await _modelRepository.ListAsync(cancellationToken);

        // Assert
        IsNotNull(result);
        That(result.Count, Is.EqualTo(entities.Count));
        That(result.FirstOrDefault()?.Id.Value, Is.EqualTo(entities.FirstOrDefault()?.Id.Value));
        That(result.FirstOrDefault()?.Name, Is.EqualTo(entities.FirstOrDefault()?.Name));
        That(result.FirstOrDefault()?.BrandId, Is.EqualTo(entities.FirstOrDefault()?.BrandId));
        That(result.FirstOrDefault()?.Description, Is.EqualTo(entities.FirstOrDefault()?.Description));
        That(result.FirstOrDefault()?.CreateDateTime, Is.EqualTo(entities.FirstOrDefault()?.CreateDateTime));
        That(result.FirstOrDefault()?.UpdateDateTime, Is.EqualTo(entities.FirstOrDefault()?.UpdateDateTime));
    }

    [Test]
    public async Task AddAsync_WhenEntityAdded_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Model.Create("ModelName1", "Description for Model 1", BrandId.CreateUnique());
        var cancellationToken = new CancellationToken();

        // Act
        var result = await _modelRepository.AddAsync(entityToAdd, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Name, Is.EqualTo(entityToAdd.Name));
        That(result.BrandId, Is.EqualTo(entityToAdd.BrandId));
        That(result.Description, Is.EqualTo(entityToAdd.Description));
        That(result.CreateDateTime, Is.EqualTo(entityToAdd.CreateDateTime));
        That(result.UpdateDateTime, Is.EqualTo(entityToAdd.UpdateDateTime));
    }

    [Test]
    public async Task UpdateAsync_WhenEntityUpdated_ReturnsUpdatedEntity()
    {
        // Arrange
        var entity = Model.Create("ModelName1", "Description for Model 1", BrandId.CreateUnique());
        var cancellationToken = new CancellationToken();
        await _modelRepository.AddAsync(entity, cancellationToken);

        // Act
        var updatedName = "Updated Model Name";
        var updatedDescription = "Updated description";
        var updatedBrandId = BrandId.CreateUnique();

        var entityFromDatabase = await _modelRepository.GetByIdAsync(entity.Id.Value, cancellationToken);
        That(entityFromDatabase, Is.Not.Null);

        entityFromDatabase!.Update(updatedName, updatedDescription, updatedBrandId);
        var result = await _modelRepository.UpdateAsync(entityFromDatabase, cancellationToken);

        // Assert
        That(result, Is.Not.Null);
        That(result.Name, Is.EqualTo(updatedName));
        That(result.BrandId, Is.EqualTo(updatedBrandId));
        That(result.Description, Is.EqualTo(updatedDescription));
    }

    [Test]
    public async Task DeleteAsync_WhenEntityDeleted_ReturnsTrue()
    {
        // Arrange
        var entity = Model.Create("ModelName1", "Description for Model 1", BrandId.CreateUnique());
        var cancellationToken = new CancellationToken();
        await _modelRepository.AddAsync(entity, cancellationToken);

        // Act
        var result = await _modelRepository.DeleteAsync(entity, cancellationToken);

        // Assert
        IsTrue(result > 0);
    }

    [Test]
    public async Task GetByIdAsync_WhenEntityExists_ReturnsMappedEntity()
    {
        // Arrange
        var entityToAdd = Model.Create("ModelName1", "Description for Model 1", BrandId.CreateUnique());
        var cancellationToken = new CancellationToken();
        var entityModel = await _modelRepository.AddAsync(entityToAdd, cancellationToken);

        // Act
        var result = await _modelRepository.GetByIdAsync(entityToAdd.Id.Value, cancellationToken);

        // Assert
        IsNotNull(result);
        That(result!.Id.Value, Is.EqualTo(entityModel.Id.Value));
        That(result.Name, Is.EqualTo(entityModel.Name));
        That(result.BrandId, Is.EqualTo(entityModel.BrandId));
        That(result.Description, Is.EqualTo(entityModel.Description));
        That(result.CreateDateTime, Is.EqualTo(entityModel.CreateDateTime));
        That(result.UpdateDateTime, Is.EqualTo(entityModel.UpdateDateTime));
    }
}