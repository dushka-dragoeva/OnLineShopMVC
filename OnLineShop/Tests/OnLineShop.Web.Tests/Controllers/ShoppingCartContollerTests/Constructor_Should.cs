using System;

using Moq;
using NUnit.Framework;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Controllers;

namespace OnLineShop.Web.Tests.Controllers.ShoppingCartContollerTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void ReturnsAnInstance_WhenParameterIsValid()
        {
            // Arrange 
            var productServiceMock = new Mock<IProductService>();
            var orderServiceMock = new Mock<IOrderService>();
            var orderDetailsServiceMock = new Mock<IOrderDetailsService>();
            var contactInfoServiceMock = new Mock<IContactInfoService>();
            var userServiceMock = new Mock<IUserService>();
            var sizeServiceMock = new Mock<ISizeService>();

            //Act
            ShoppingCartController shoppingCartController = new ShoppingCartController(
                productServiceMock.Object,
                orderServiceMock.Object,
                orderDetailsServiceMock.Object,
                contactInfoServiceMock.Object,
                userServiceMock.Object,
                sizeServiceMock.Object);

            // Assert
            Assert.IsNotNull(shoppingCartController);
        }

        [Test]
        public void ThrowException_WhenParametersAreNull()
        {
            // Arrange & Act & Assert

            Assert.Throws<ArgumentNullException>(() => new ShoppingCartController(null, null, null, null, null, null));
        }

        [Test]
        public void ThrowException_WhenProductServiceIsNull()
        {
            // Arrange 
            var orderServiceMock = new Mock<IOrderService>();
            var orderDetailsServiceMock = new Mock<IOrderDetailsService>();
            var contactInfoServiceMock = new Mock<IContactInfoService>();
            var userServiceMock = new Mock<IUserService>();
            var sizeServiceMock = new Mock<ISizeService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ShoppingCartController(
                null,
                orderServiceMock.Object,
                orderDetailsServiceMock.Object,
                contactInfoServiceMock.Object,
                userServiceMock.Object,
                sizeServiceMock.Object));
        }

        [Test]
        public void ThrowException_WhenOrderServiceIsNull()
        {
            // Arrange 
            var productServiceMock = new Mock<IProductService>();
            var orderDetailsServiceMock = new Mock<IOrderDetailsService>();
            var contactInfoServiceMock = new Mock<IContactInfoService>();
            var userServiceMock = new Mock<IUserService>();
            var sizeServiceMock = new Mock<ISizeService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ShoppingCartController(
                productServiceMock.Object,
                null,
                orderDetailsServiceMock.Object,
                contactInfoServiceMock.Object,
                userServiceMock.Object,
                sizeServiceMock.Object));
        }

        [Test]
        public void ThrowException_WhenOrderDetailsServiceIsNull()
        {
            // Arrange 
            var productServiceMock = new Mock<IProductService>();
            var orderServiceMock = new Mock<IOrderService>();
            var contactInfoServiceMock = new Mock<IContactInfoService>();
            var userServiceMock = new Mock<IUserService>();
            var sizeServiceMock = new Mock<ISizeService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ShoppingCartController(
                productServiceMock.Object,
                orderServiceMock.Object,
                null,
                contactInfoServiceMock.Object,
                userServiceMock.Object,
                sizeServiceMock.Object));
        }

        [Test]
        public void ThrowException_WhenContactInfoServiceIsNull()
        {
            // Arrange 
            var productServiceMock = new Mock<IProductService>();
            var orderServiceMock = new Mock<IOrderService>();
            var orderDetailsServiceMock = new Mock<IOrderDetailsService>();
            var userServiceMock = new Mock<IUserService>();
            var sizeServiceMock = new Mock<ISizeService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ShoppingCartController(
                productServiceMock.Object,
                orderServiceMock.Object,
                orderDetailsServiceMock.Object,
                null,
                userServiceMock.Object,
                sizeServiceMock.Object));
        }

        [Test]
        public void ThrowException_WhenUserServiceIsNull()
        {
            // Arrange 
            var productServiceMock = new Mock<IProductService>();
            var orderServiceMock = new Mock<IOrderService>();
            var orderDetailsServiceMock = new Mock<IOrderDetailsService>();
            var contactInfoServiceMock = new Mock<IContactInfoService>();
            var sizeServiceMock = new Mock<ISizeService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ShoppingCartController(
                productServiceMock.Object,
                orderServiceMock.Object,
                orderDetailsServiceMock.Object,
                contactInfoServiceMock.Object,
                null,
                sizeServiceMock.Object));
        }

        [Test]
        public void ThrowException_WhenSizeServiceIsNull()
        {
            // Arrange 
            var productServiceMock = new Mock<IProductService>();
            var orderServiceMock = new Mock<IOrderService>();
            var orderDetailsServiceMock = new Mock<IOrderDetailsService>();
            var contactInfoServiceMock = new Mock<IContactInfoService>();
            var userServiceMock = new Mock<IUserService>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ShoppingCartController(
                productServiceMock.Object,
                orderServiceMock.Object,
                orderDetailsServiceMock.Object,
                contactInfoServiceMock.Object,
                userServiceMock.Object,
                null));
        }
    }
}
