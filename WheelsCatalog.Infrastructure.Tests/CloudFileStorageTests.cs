using Microsoft.Extensions.Configuration;
using Moq;
using WheelsCatalog.Application.DTOs.sharedDtos;
using WheelsCatalog.Infrastructure.file;

namespace WheelsCatalog.Infrastructure.Tests;

[TestFixture]
    public class CloudFileStorageTests
    {
        private Mock<IConfiguration> _mockConfiguration = null!;

        [SetUp]
        public void Setup()
        {
            _mockConfiguration = new Mock<IConfiguration>();
        }
        
        [Test]
        public async Task UploadToCloud_SuccessfullyUploadsFile()
        {
            // Arrange
            var file = new FileDto
            {
                FileName = "test.jpg",
                ContentType = "image/jpeg",
                Data = "%PDF"u8.ToArray()
            };
            
            const string apiKey = "AIzaSyAwJ9s47kaure2M2mXmHhR3_giKh2sg85Y";
            const string bucket = "wheelscatalog-564d8.appspot.com";
            const string authEmail = "wheels_catalog_admin@gmail.com";
            const string authPwd = "123567";
            _mockConfiguration.Setup(x => x["Firebase:ApiKey"]).Returns(apiKey);
            _mockConfiguration.Setup(x => x["Firebase:Bucket"]).Returns(bucket);
            _mockConfiguration.Setup(x => x["Firebase:AuthEmail"]).Returns(authEmail);
            _mockConfiguration.Setup(x => x["Firebase:AuthPwd"]).Returns(authPwd);

            var localFileStorage = new LocalFileStorage();
            var cloudFileStorage = new CloudFileStorage(_mockConfiguration.Object);

            // Act
            var localLink = await localFileStorage.SaveLocal(file);
            var cloudLink = await cloudFileStorage.UploadToCloud(new FileStream(localLink.Item1, FileMode.Open), localLink.Item2);

            // Assert
            Assert.IsNotNull(cloudLink);
        }

        [Test]
        public async Task UploadToCloud_ThrowsException_WhenAuthenticationFails()
        {
            // Arrange
            var file = new FileDto
            {
                FileName = "test.jpg",
                ContentType = "image/jpeg",
                Data = "%PDF"u8.ToArray()
            };
            
            const string apiKey = "";
            const string bucket = "";
            const string authEmail = "";
            const string authPwd = "";
            _mockConfiguration.Setup(x => x["Firebase:ApiKey"]).Returns(apiKey);
            _mockConfiguration.Setup(x => x["Firebase:Bucket"]).Returns(bucket);
            _mockConfiguration.Setup(x => x["Firebase:AuthEmail"]).Returns(authEmail);
            _mockConfiguration.Setup(x => x["Firebase:AuthPwd"]).Returns(authPwd);

            var localFileStorage = new LocalFileStorage();
            var cloudFileStorage = new CloudFileStorage(_mockConfiguration.Object);

            // Act & Assert
            var localLink = await localFileStorage.SaveLocal(file);
            Assert.Throws<AggregateException>(() =>
                cloudFileStorage.UploadToCloud(new FileStream(localLink.Item1, FileMode.Open), localLink.Item2).Wait());
        }
    }