﻿using Moq;
using NUnit.Framework;

using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data;

namespace OnLineShop.Services.Tests.ProductServiceTest
{
    [TestFixture]
    public class GetById_Should
    {
        [Test]
        public void ReturnProduct_WhenThereIsAModelWithThePassedId()
        {
            var wrapperMock = new Mock<IEfDbSetWrapper<Product>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            int productId = 1;

            wrapperMock.Setup(m => m.GetById(productId)).Returns(new Product() { Id = productId });

            ProductService productService = new ProductService(wrapperMock.Object, dbContextMock.Object);

            // Act
            Product product = productService.GetById(productId);

            // Assert
            Assert.IsNotNull(product);
        }

        [Test]
        public void ReturnNull_WhenIdParameterIsNull()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Product>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            ProductService productService = new ProductService(wrapperMock.Object, dbContextMock.Object);

            // Act
            Product product = productService.GetById(null);

            // Assert
            Assert.IsNull(product);
        }

        [Test]
        public void ReturnNull_WhenThereIsNoModelWithThePassedId()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Product>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            int id = 1;

            ProductService productService = new ProductService(wrapperMock.Object, dbContextMock.Object);
            wrapperMock.Setup(m => m.GetById(id)).Returns((Product)null);

            // Act
            Product Product = productService.GetById(id);

            // Assert
            Assert.IsNull(Product);
        }
    }
}
