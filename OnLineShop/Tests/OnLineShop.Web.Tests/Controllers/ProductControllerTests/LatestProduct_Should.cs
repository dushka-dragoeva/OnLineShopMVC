using System.Collections.Generic;

using Moq;
using NUnit.Framework;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Web.Controllers;
using OnLineShop.Web.Models.Products;
using TestStack.FluentMVCTesting;

namespace OnLineShop.Web.Tests.Controllers.ProductControllerTests
{
    [TestFixture]
    public class LatestProduct_Should
    {
        [Test]
        public void ReturnPartialViewWithCattegories_WhenPassedPatameterIsNotEmptyCollection()
        {
            // Arrange
            var productService = new Mock<IProductService>();

            Product first = new Product()
            {
                Id = 5,
                Name = "Рокля на цветя",
                PictureUrl = "www.go.home",
                Category = new Category { Id = 2, Name = "Поли" },
                Brand = new Brand() { Id = 1, Name = "Levis" },
                Price = 55.20m,
                ModelNumber = "123",
                Quantity = 5,
                Sizes = new List<Size> { new Size { Id = 5, Value = "36" }, new Size { Id = 7, Value = "40" } }
            };
            Product second = new Product()
            {
                Id = 7,
                Name = "Рокля на цветя",
                PictureUrl = "www.go.home",
                Category = new Category { Id = 2, Name = "Поли" },
                Brand = new Brand() { Id = 1, Name = "Levis" },
                Price = 55.20m,
                ModelNumber = "123",
                Quantity = 5,
                Sizes = new List<Size> { new Size { Id = 5, Value = "36" }, new Size { Id = 7, Value = "40" } }
            };

            var productList = new List<Product>() { first, second };

            productService.Setup(p => p.GetLast12WithCategoryAndBrand()).Returns(productList);

            // Act
            var productController = new ProductController(productService.Object);

            //  Assert
            productController
                .WithCallTo(p => p.LatestProducts())
                .ShouldRenderPartialView("_ProductsPartial")
                .WithModel<IEnumerable<ProductsViewModel>>(); ;
        }

        [Test]
        public void ReturnEmptyPartialView_WhenPassedPatameterIsEmptyCollection()
        {
            // Arrange
            var productService = new Mock<IProductService>();
            IEnumerable<Product> productList = new List<Product>();

            productService.Setup(p => p.GetLast12WithCategoryAndBrand()).Returns(productList);

            // Act
            var ProductController = new ProductController(productService.Object);

            //  Assert
            ProductController
                .WithCallTo(c => c.LatestProducts())
                .ShouldRenderPartialView("_ProductsPartial");
        }
    }
}
