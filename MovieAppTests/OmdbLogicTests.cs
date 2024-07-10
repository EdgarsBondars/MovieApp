using System.Net;
using Microsoft.Extensions.Configuration;
using Moq;
using MovieApp.Server;
using MovieApp.Server.Logic;

namespace MovieApp.Tests
{
    public class OmdbLogicTests
    {
        private readonly Mock<IConfiguration> _mockConfiguration;
        private readonly Mock<IHttpClientHandler> _mockHttpClientHandler;
        private readonly OmdbLogic _omdbLogic;

        public OmdbLogicTests()
        {
            _mockConfiguration = new Mock<IConfiguration>();
            _mockHttpClientHandler = new Mock<IHttpClientHandler>();
            _omdbLogic = new OmdbLogic(_mockConfiguration.Object, _mockHttpClientHandler.Object);
        }

        [Fact]
        public async Task GetMoviesByTitle_EmptyTitle_ReturnsEmptyString()
        {
            // Arrange
            var movieTitle = string.Empty;

            // Act
            var result = await _omdbLogic.GetMoviesByTitle(movieTitle);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public async Task GetMoviesByTitle_ValidTitle_ReturnsMovieList()
        {
            // Arrange
            var movieTitle = "Inception";
            var expectedResponse = "{\"Title\":\"Inception\"}";
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(expectedResponse)
            };

            _mockConfiguration.Setup(c => c["OmdbApiKey"]).Returns("test_api_key");
            _mockHttpClientHandler
                .Setup(h => h.GetAsync(It.IsAny<string>()))
                .ReturnsAsync(httpResponseMessage);

            // Act
            var result = await _omdbLogic.GetMoviesByTitle(movieTitle);

            // Assert
            Assert.Equal(expectedResponse, result);
        }

        [Fact]
        public async Task GetMovieByOmdbId_EmptyId_ReturnsEmptyString()
        {
            // Arrange
            var omdbId = string.Empty;

            // Act
            var result = await _omdbLogic.GetMovieByOmdbId(omdbId);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public async Task GetMovieByOmdbId_ValidId_ReturnsMovieDetails()
        {
            // Arrange
            var omdbId = "tt1375666";
            var expectedResponse = "{\"Title\":\"Inception\"}";
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(expectedResponse)
            };

            _mockConfiguration.Setup(c => c["OmdbApiKey"]).Returns("test_api_key");
            _mockHttpClientHandler
                .Setup(h => h.GetAsync(It.IsAny<string>()))
                .ReturnsAsync(httpResponseMessage);

            // Act
            var result = await _omdbLogic.GetMovieByOmdbId(omdbId);

            // Assert
            Assert.Equal(expectedResponse, result);
        }
    }
}
