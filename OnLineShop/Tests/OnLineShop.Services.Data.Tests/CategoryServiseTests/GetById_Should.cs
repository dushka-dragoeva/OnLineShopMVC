using System.Data.Entity;

using Moq;

using OnLineShop.Data;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data;
using NUnit.Framework;
using OnLineShop.Data.Contracts;

namespace OnLineShop.Services.Tests.CategoryServiseTests
{
    [TestFixture]
    public class GetById_Should
    {
        [Test]
        public void ReturnProduct_WhenIdIsValid()
        {
            // Arrange
            var contextMock = new Mock<IOnLineShopDbContext>();
            var productSetMock = new Mock<IDbSet<Product>>();
            contextMock.Setup(c => c.Products).Returns(productSetMock.Object);
            int productId = 1;
            Product product = new Product() { Id = productId, Name = "Product 1", ModelNumber = "1A", Quantity = 1, Price = 33.50m };

            productSetMock.Setup(b => b.Find(productId)).Returns(product);

            ProductService productService = new ProductService(contextMock.Object);

            // Act
            Product productResult = productService.GetById(productId);

            // Assert
            Assert.AreSame(product, productResult);
        }

        [Test]
        public void ReturnNull_WhenIdParameterIsNull()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            CategoryService categoryService = new CategoryService(wrapperMock.Object, dbContextMock.Object);

            // Act
            Category category = categoryService.GetById(null);

            // Assert
            Assert.IsNull(category);
        }

        [Test]
        public void ReturnNull_WhenThereIsNoModelWithThePassedId()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            int id = 1;

            CategoryService categoryService = new CategoryService(wrapperMock.Object, dbContextMock.Object);
            wrapperMock.Setup(m => m.GetById(id)).Returns((Category)null);

            // Act
            Category category = categoryService.GetById(id);

            // Assert
            Assert.IsNull(category);
        }
    }
}

