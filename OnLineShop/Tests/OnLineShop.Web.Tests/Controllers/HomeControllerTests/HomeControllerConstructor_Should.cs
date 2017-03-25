using NUnit.Framework;
using OnLineShop.Web.Controllers;

namespace OnLineShop.Web.Tests.Controllers.HomeControllerTests
{
    [TestFixture]
    public class HomeControllerConstructor_Should
    {
        [Test]
        public void ReturnsAnInstance()
        {
            // Arrange & Act
            HomeController homeController = new HomeController();

            // Assert
            Assert.IsNotNull(homeController);
        }
    }
}
