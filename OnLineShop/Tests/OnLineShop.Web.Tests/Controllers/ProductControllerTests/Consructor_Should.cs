using System;

using NUnit.Framework;
using Moq;

using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Controllers;

namespace OnLineShop.Web.Tests.Controllers.ProductControllerTests
{
    [TestFixture]
   public class Consructor_Should
    {
        [Test]
        public void ReturnsAnInstance_WhenParameterIsValid()
        {
            // Arrange 
            var productServiceMock = new Mock<IProductService>();


            //Act
            ProductController productController = new ProductController(productServiceMock.Object);

            // Assert
            Assert.IsNotNull(productController);
        }

        [Test]
        public void ThrowException_WhenParameterIsNull()
        {
            // Arrange & Act & Assert

            Assert.Throws<ArgumentNullException>(
            () => new ProductController(null));
        }
    }
}
