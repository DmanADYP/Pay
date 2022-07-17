using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Pay.API.Controllers;
using Pay.API.Interfaces;
using System.Threading.Tasks;

namespace Pay.Test
{
    [TestClass]
    public class DataSrcControllerTest
    {
        private DataSrcController? _daraSrcController;
        private Mock<IDataSrc>? _daraSrc;
        private Mock<ILogger<DataSrcController>>? _logger;

        [TestInitialize()]
        public void Setup()
        {
            _daraSrc = new Mock<IDataSrc>();
            _logger = new Mock<ILogger<DataSrcController>>();

            _daraSrcController = new DataSrcController(_logger.Object, _daraSrc.Object);
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod]
        public async Task ShouldCallIsPalindrome()
        {
            _daraSrc.Setup(d => d.IsPalindrome(It.IsAny<string>())).ReturnsAsync(It.IsAny<bool>());

            var result = await _daraSrcController.IsPalindrome(It.IsAny<string>());

            _daraSrc.Verify(d => d.IsPalindrome(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public async Task ShouldRunIsPalindrome()
        {
            _daraSrc.Setup(d => d.IsPalindrome(It.IsAny<string>())).ReturnsAsync(It.IsAny<bool>());

            var result = await _daraSrcController.IsPalindrome(It.IsAny<string>());

            _daraSrc.Verify(d => d.IsPalindrome(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(false, result);
        }
    }
}