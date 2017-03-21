using System;

using Moq;

using NUnit.Framework;
using OnLineShop.Data;
using OnLineShop.Data.Services;


namespace OnLineShop.Services.Data.Tests.CategoryServiseTests
{
    public class Constructor_Should
    {
        [Test]
        public void CreateCategoryServices_IfParamsAreValid()
        {
            // Arrange & Act
            var contextMock = new Mock<IOnLineShopDbContext>();
            CategoryService categoryService = new CategoryService(contextMock.Object);

            // Assert
            Assert.That(categoryService, Is.InstanceOf<CategoryService>());
        }

        [Test]
        public void ThrowArgumentNullException_IfPassedDataProviderIsNull()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentNullException>(
                () => new CategoryService(null));
        }
    }
}
