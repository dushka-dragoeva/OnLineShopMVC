using System;

using Moq;
using NUnit.Framework;

using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Controllers;

namespace OnLineShop.Web.Tests.Controllers.HomeControllerTests
{
    public class CategoryControllerConstructor_Should
    {
        [Test]
        public void ReturnsAnInstance()
        {
            // Arrange & Act
            HomeController homeController = new HomeController();

            // Assert
            Assert.IsNotNull(homeController);
        }

        //[Test]
        //public void ThrowException_WhenParametersAreNull()
        //{
        //    // Arrange & Act & Assert

        //    Assert.Throws<ArgumentNullException>(
        //    () => new HomeController(null, null));
        //}

        //[Test]
        //public void ThrowException_WhenParametersCategoryServiceIsNull()
        //{
        //    // Arrange 
        //    var categoryServiceMock = new Mock<ICategoryService>();

        //    // Act & Assert

        //    Assert.Throws<ArgumentNullException>(() => new HomeController(null, categoryServiceMock.Object));
        //}

        //[Test]
        //public void ThrowException_WhenParametersProductServiceISNull()
        //{
        //    // Arrange 
        //    var productServiceMock = new Mock<IProductService>();

        //    //Act & Assert
        //    Assert.Throws<ArgumentNullException>(() => new HomeController(productServiceMock.Object, null));
        //}
    }
}
