using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;
using Moq;

using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;

namespace OnLineShop.Services.Data.Tests.ProductServiceTest
{
    [TestFixture]
    public class GetAll_Should
    {
        [Test]
        public void BeCalled_WhenParamsAreValid()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Product>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            ProductService productService = new ProductService(wrapperMock.Object, dbContextMock.Object);

            // Act
            productService.GetAllWithCategoryBrand();

            // Assert
            wrapperMock.Verify(rep => rep.All(), Times.Once);
        }

        [Test]
        public void NotBeCalled_IfItIsNeverCalled()
        {
            // Arrange & Act
            var wrapperMock = new Mock<IEfDbSetWrapper<Product>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            // Assert
            wrapperMock.Verify(rep => rep.All(), Times.Never);
        }

        [Test]
        public void ReturnCorrectCollection_IfCalled()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Product>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            ProductService productService = new ProductService(wrapperMock.Object, dbContextMock.Object);

            // Act
            IEnumerable<Product> expectedProductsResult = new List<Product>() { new Product(), new Product() };
            wrapperMock.Setup(rep => rep.All()).Returns(() => expectedProductsResult.AsQueryable());

            // Assert
            Assert.AreEqual(productService.GetAllWithCategoryBrand(), expectedProductsResult);
        }
    }
}
