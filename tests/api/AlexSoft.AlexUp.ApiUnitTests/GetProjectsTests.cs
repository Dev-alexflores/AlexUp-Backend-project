namespace AlexSoft.AlexUp.ApiUnitTests
{
    using AlexSoft.AlexUp.CoreInterfaces;
    using AlexSoft.AlexUp.Models;
    using AlexSoft.AlexUp.Projects;
    using AlexSoft.AlexUp.Projects.Controllers;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using Xunit;

    public class GetProjectsTests
    {
        private readonly Mock<IProjectsService> mockService;
        private readonly DefaultHttpContext mockHttpContext;
        private readonly GetHealth getHealth;

        public GetProjectsTests()
        {
            this.mockService = new Mock<IProjectsService>();
            this.mockHttpContext = new DefaultHttpContext();
            this.getHealth = new GetHealth(this.mockService.Object);
        }

        [Fact]
        public void GetProjects_ShouldReturnAllProjects()
        {
            // Arrange
            Project[] projects = new Project[2];
            projects[0] = StubProject.GetStubProject();
            var request = this.mockHttpContext.Request;
            this.mockService.Setup(service => service.GetHealth()).Returns("string");

            // Act
            var result = this.getHealth.Health(request);

            // Assert
            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            Assert.IsType<string>(okObjectResult.Value);
        }
    }
}