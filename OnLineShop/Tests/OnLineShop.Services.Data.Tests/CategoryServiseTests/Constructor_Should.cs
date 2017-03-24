using System;

using Moq;
using NUnit.Framework;

using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;

namespace OnLineShop.Services.Data.Tests.CategoryServiseTests
{
    public class Constructor_Should
    {
        [Test]
        public void ReturnsAnInstance_WhenBothParametersAreNotNull()
        {
            // Arrange 
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            // Act
            CategoryService categoryService = new CategoryService(wrapperMock.Object, dbContextMock.Object);

            // Assert
            Assert.That(categoryService, Is.InstanceOf<CategoryService>());
        }

        [Test]
        public void ThrowArgumentNullException_WhenCategorySetWrapperIsNull()
        {
            // Arrange
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(
                () => new CategoryService(null, dbContextMock.Object));
        }

        [Test]
        public void ThrowArgumentNullException_WhenCategoryDbContextIsNull()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(
                () => new CategoryService(wrapperMock.Object, null));
        }
    }
}
