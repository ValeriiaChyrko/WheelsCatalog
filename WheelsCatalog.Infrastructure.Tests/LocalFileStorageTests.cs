using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Infrastructure.file;

namespace WheelsCatalog.Infrastructure.Tests;

[TestFixture]
    public class LocalFileStorageTests
    {
        [Test]
        public void GetUniqueFileName_ReturnsUniqueFileName()
        {
            // Arrange
            var fileName = "document.pdf";

            // Act
            var uniqueFileName = LocalFileStorage.GetUniqueFileName(fileName);

            // Assert
            Assert.IsNotNull(uniqueFileName);
            Assert.That(uniqueFileName, Is.Not.EqualTo(fileName));

            var parts = uniqueFileName.Split('_');
            Assert.That(parts.Length, Is.EqualTo(2));
            Assert.That(parts[0], Is.EqualTo(Path.GetFileNameWithoutExtension(fileName)));
            Assert.That(Path.GetExtension(parts[1]), Is.EqualTo(Path.GetExtension(fileName)));
        }

        [Test]
        public async Task SaveLocal_ValidFile_SavesFile()
        {
            // Arrange
            var file = new FileDto
            {
                FileName = "test.jpg",
                ContentType = "image/jpeg",
                Data = "%PDF"u8.ToArray()
            };

            var storage = new LocalFileStorage();

            // Act
            var result = await storage.SaveLocal(file);

            // Assert
            Assert.IsTrue(File.Exists(result.Item1));
        }

        [Test]
        public Task SaveLocal_EmptyData_ThrowsArgumentException()
        {
            // Arrange
            var file = new FileDto
            {
                FileName = "test.jpg",
                ContentType = "image/jpeg",
                Data = Array.Empty<byte>()
            };

            var storage = new LocalFileStorage();

            // Act & Assert
            Assert.Throws<AggregateException>(() => storage.SaveLocal(file).Wait());
            return Task.CompletedTask;
        }
    }