using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Moq;
using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;

namespace OnLineShop.Services.Data.Tests.ProductServiceTest
{
    [TestFixture]
   public class Constructor_Should
    {
        [Test]
        public void ReturnsAnInstance_WhenBothParametersAreNotNull()
        {
            // Arrange 
            var wrapperMock = new Mock<IEfDbSetWrapper<Product>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            // Act
            ProductService productService = new ProductService(wrapperMock.Object, dbContextMock.Object);

            // Assert
            Assert.That(productService, Is.InstanceOf<ProductService>());
        }

        [Test]
        public void ThrowArgumentNullException_WhenProductSetWrapperIsNull()
        {
            // Arrange
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(
                () => new ProductService(null, dbContextMock.Object));
        }

        [Test]
        public void ThrowArgumentNullException_WhenProductDbContextIsNull()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Product>>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(
                () => new ProductService(wrapperMock.Object, null));
        }
    }
}
