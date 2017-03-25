using System;

using Moq;
using NUnit.Framework;

using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Controllers;

namespace OnLineShop.Web.Tests.Controllers.CategoryControllerTessts
{
    [TestFixture]
    public class CategoryControllerConstructor_Should
    {
        [Test]
        public void ReturnsAnInstance()
        {
            // Arrange 
            var categoryServiceMock = new Mock<ICategoryService>();


            //Act
            CategoryController categoryController = new CategoryController(categoryServiceMock.Object);

            // Assert
            Assert.IsNotNull(categoryController);
        }

        [Test]
        public void ThrowException_WhenParameterIsNull()
        {
            // Arrange & Act & Assert

            Assert.Throws<ArgumentNullException>(
            () => new CategoryController(null));
        }
    }
}
