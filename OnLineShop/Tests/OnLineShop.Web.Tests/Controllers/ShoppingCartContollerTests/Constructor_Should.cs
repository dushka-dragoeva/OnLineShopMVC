﻿using System;

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
            //// Arrange 
            //var productServiceMock = new Mock<IProductService>();
            //var orderServiceMock = new Mock<IOrderService>();
            //var orderDetailsServiceMock = new Mock<IOrderDetailsService>();


            ////Act
            //ShoppingCartController shoppingCartController = new ShoppingCartController(
            //    productServiceMock.Object, 
            //    orderServiceMock.Object, 
            //    orderDetailsServiceMock.Object  );

            //// Assert
            //Assert.IsNotNull(shoppingCartController);
        }

        [Test]
        public void ThrowException_WhenParameterIsNull()
        {
            // Arrange & Act & Assert

            Assert.Throws<ArgumentNullException>(() => new ShoppingCartController(null, null,null,null,null,null));
        }
    }
}
