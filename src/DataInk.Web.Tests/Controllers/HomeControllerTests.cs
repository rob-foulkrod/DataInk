using DataInk.Web.Controllers;
using DataInk.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

namespace DataInk.Web.Tests.Controllers
{
    public class HomeControllerTests
    {
        private readonly HomeController _controller;
        private readonly ILogger<HomeController> _logger;

        public HomeControllerTests()
        {
            _logger = new LoggerFactory().CreateLogger<HomeController>();
            _controller = new HomeController(_logger);
        }

        [Fact]
        public void Index_ReturnsAViewResult()
        {
            // Act
            var result = _controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Privacy_ReturnsAViewResult()
        {
            // Act
            var result = _controller.Privacy();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

    }
}
