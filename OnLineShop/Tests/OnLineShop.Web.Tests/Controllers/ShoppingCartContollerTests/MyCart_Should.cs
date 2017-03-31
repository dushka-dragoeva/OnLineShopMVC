using System.Web;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

using Moq;
using NUnit.Framework;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Controllers;
using OnLineShop.Web.Models.ShoppingCart;
using System.Collections.Generic;

namespace OnLineShop.Web.Tests.Controllers.ShoppingCartContollerTests
{
    [TestFixture]
    public class MyCart_Should
    {
        [Test]
        public void ReturnEmptyCart_WhenThereIsNotAnyProduct()
        {
            // Arrange 
            var mockControllerContext = new Mock<ControllerContext>();
            var mockSession = new Mock<HttpSessionStateBase>();
            mockSession.SetupGet(s => s["cart"]).Returns(null);
            mockControllerContext.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);

            var productServiceMock = new Mock<IProductService>();
            var orderServiceMock = new Mock<IOrderService>();
            var orderDetailsServiceMock = new Mock<IOrderDetailsService>();
            var contactInfoServiceMock = new Mock<IContactInfoService>();
            var userServiceMock = new Mock<IUserService>();
            var sizeServiceMock = new Mock<ISizeService>();

            ShoppingCartController shoppingCartController = new ShoppingCartController(
                 productServiceMock.Object,
                 orderServiceMock.Object,
                 orderDetailsServiceMock.Object,
                 contactInfoServiceMock.Object,
                 userServiceMock.Object,
                 sizeServiceMock.Object);
            shoppingCartController.ControllerContext = mockControllerContext.Object;

            // Act & Assert
            shoppingCartController
                 .WithCallTo(s => s.MyCart())
                     .ShouldRenderView("EmptyCart");
        }

        [Test]
        public void ReturnCart_WhenThereIsProducts()
        {
            // Arrange 
            var controllerContextMock = new Mock<ControllerContext>();
            var sessionMock = new Mock<HttpSessionStateBase>();
            var productServiceMock = new Mock<IProductService>();
            var orderServiceMock = new Mock<IOrderService>();
            var orderDetailsServiceMock = new Mock<IOrderDetailsService>();
            var contactInfoServiceMock = new Mock<IContactInfoService>();
            var userServiceMock = new Mock<IUserService>();
            var sizeServiceMock = new Mock<ISizeService>();

            ShoppingCartController shoppingCartController = new ShoppingCartController(
                productServiceMock.Object,
                orderServiceMock.Object,
                orderDetailsServiceMock.Object,
                contactInfoServiceMock.Object,
                userServiceMock.Object,
                sizeServiceMock.Object);
            shoppingCartController.CartItems = new List<OrderDetailViewModel>();

            sessionMock.SetupGet(s => s["cart"]).Returns(shoppingCartController.CartItems);
            controllerContextMock.Setup(p => p.HttpContext.Session).Returns(sessionMock.Object);

            shoppingCartController.ControllerContext = controllerContextMock.Object;

            // Act & Assert
            shoppingCartController
                 .WithCallTo(s => s.MyCart())
                     .ShouldRenderView("MyCart");

        }
    }
}
