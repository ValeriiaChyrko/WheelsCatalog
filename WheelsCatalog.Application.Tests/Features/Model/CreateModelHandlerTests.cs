using Moq;
using NUnit.Framework;
using WheelsCatalog.Application.Contracts.Persistence.Interfaces.Repository.Common;
using WheelsCatalog.Application.DTOs.requestsDtos;
using WheelsCatalog.Application.Features.Model.Commands.Handlers;
using WheelsCatalog.Application.Features.Model.Commands.Requests;
using WheelsCatalog.Domain.BrandAggregate.ValueObjects;

namespace WheelsCatalog.Application.Tests.Features.Model;

[TestFixture]
public class CreateModelHandlerTests
{
    [Test]
    public void Handle_ValidModel_ReturnsModelId()
    {
        // Arrange
        var modelRepositoryMock = new Mock<IUnitOfWork>();
        var handler = new CreateModelHandler(modelRepositoryMock.Object);
        var createModelRequest = new CreateModelRequest
        {
            ModelDto = new RequestModelDto
                { Name = "TestModel", Description = "TestDescription", BrandId = BrandId.CreateUnique().Value }
        };

        // Act
        var result = handler.Handle(createModelRequest, CancellationToken.None).Result;

        // Assert
        Assert.IsNotNull(result);
        modelRepositoryMock.Verify(x => x.ModelRepository.AddAsync(It.IsAny<Domain.ModelAggregate.Model>(), CancellationToken.None),
            Times.Once);
    }

    [Test]
    public void Handle_ValidModel_AddsModelToRepository()
    {
        // Arrange
        var modelRepositoryMock = new Mock<IUnitOfWork>();
        var handler = new CreateModelHandler(modelRepositoryMock.Object);
        var createModelRequest = new CreateModelRequest
        {
            ModelDto = new RequestModelDto
                { Name = "TestModel", Description = "TestDescription", BrandId = BrandId.CreateUnique().Value }
        };

        // Act
        _ = handler.Handle(createModelRequest, CancellationToken.None).Result;

        // Assert
        modelRepositoryMock.Verify(repo => repo.ModelRepository.AddAsync(It.IsAny<Domain.ModelAggregate.Model>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}