using AutoMapper;
using NUnit.Framework;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;
using WheelsCatalog.Domain.ModelAggregate;
using WheelsCatalog.Persistence.Mappers;
using WheelsCatalog.Persistence.Mappers.Common;
using WheelsCatalog.Persistence.Mappers.Profiles;
using WheelsCatalog.Persistence.Models;
using static NUnit.Framework.Assert;

namespace WheelsCatalog.Persistence.Tests.Mappers;

[TestFixture]
    public class ModelMapperTests
    {
        private IEntityMapper<Model, ModelEntityModel> _modelMapper = null!;
        private IMapper _mapper = null!;

        [SetUp]
        public void Setup()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BrandMappingProfile>();
                cfg.AddProfile<ModelMappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            
            _modelMapper = new ModelMapper(_mapper);
        }

        [Test]
        public void MapToModel_WhenEntityMapped_ReturnsCorrectModel()
        {
            // Arrange
            var entity = Model.Create("Model 1", "Description for Model 1", BrandId.CreateUnique());

            // Act
            var model = _modelMapper.MapToModel(entity);

            // Assert
            That(model, Is.Not.Null);
            That(model.Id, Is.EqualTo(entity.Id.Value));
            That(model.Name, Is.EqualTo(entity.Name));
            That(model.BrandId, Is.EqualTo(entity.BrandId.Value));
            That(model.Description, Is.EqualTo(entity.Description));
            That(model.CreateDateTime, Is.EqualTo(entity.CreateDateTime));
            That(model.UpdateDateTime, Is.EqualTo(entity.UpdateDateTime));
        }

        [Test]
        public void MapToEntity_WhenModelMapped_ReturnsCorrectEntity()
        {
            // Arrange
            var model = new ModelEntityModel
            {
                Id = Guid.NewGuid(),
                Name = "Model 1",
                Description = "Description for Model 1",
                CreateDateTime = DateTime.Now,
                UpdateDateTime = DateTime.Now,
                BrandId = Guid.NewGuid()
            };

            // Act
            var entity = _modelMapper.MapToEntity(model);
            
            // Assert
            That(entity, Is.Not.Null);
            That(entity.Id.Value, Is.EqualTo(model.Id));
            That(entity.Name, Is.EqualTo(model.Name));
            That(entity.BrandId.Value, Is.EqualTo(model.BrandId));
            That(entity.Description, Is.EqualTo(model.Description));
            That(entity.CreateDateTime, Is.EqualTo(model.CreateDateTime));
            That(entity.UpdateDateTime, Is.EqualTo(model.UpdateDateTime));
        }
    }