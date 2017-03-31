using System.Collections.Generic;
using System.Linq;

using Moq;
using NUnit.Framework;
using TestStack.FluentMVCTesting;

using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Controllers;

namespace OnLineShop.Web.Tests.Controllers.ProductControllerTests
{
    [TestFixture]
    public class ProductDetails_Should
    {
        [Test]
        public void ReturnViewWithModelWithCorrectProperties_WhenThereIsAModelWithThePassedId()
        {
            // Arrange
            var ProductServiceMock = new Mock<IProductService>();

            Product product = new Product()
            {
                Id = 5,
                Name = "Рокля на цветя",
                PictureUrl = "www.go.home",
                Category = new Category { Id = 2, Name = "Поли" },
                Brand = new Brand() { Id = 1, Name = "Levis" },
                Price = 55.20m,
                ModelNumber = "123",
                Quantity=5,
                Sizes= new List<Size> { new Size { Id=5, Value="36"}, new Size { Id = 7, Value = "40" } }
            };

            var ProductViewModel = new ProductDetailsViewModel(product);

            ProductServiceMock.Setup(m => m.GetById(product.Id)).Returns(product);

            ProductController productController = new ProductController(ProductServiceMock.Object);

            // Act & Assert
            productController
                .WithCallTo(c => c.ProductDetails(product.Id))
                    .ShouldRenderDefaultView()
                    .WithModel<ProductDetailsViewModel>(viewModel =>
                    {
                        Assert.AreEqual(product.Id, viewModel.Id);
                        Assert.AreEqual(product.Name, viewModel.Name);
                        Assert.AreEqual(product.PictureUrl, viewModel.PictureUrl);
                        Assert.AreEqual(product.Category.Name, viewModel.CategoryName);
                        Assert.AreEqual(product.Brand.Name, viewModel.BrandName);
                        Assert.AreEqual(product.Price, viewModel.Price);
                        Assert.AreEqual(product.ModelNumber, viewModel.ModelNumber);
                        Assert.AreEqual(product.Sizes.Count, viewModel.Sizes.Count());

                    });
        }

        [Test]
        public void ReturnProductNotFound_WhenThereNoModelWithThePassedId()
        {
            // Arrange
            var productServiceMock = new Mock<IProductService>();

            var productViewModel = new ProductDetailsViewModel();
            int? ProductId = 5;
            productServiceMock.Setup(m => m.GetById(ProductId)).Returns((Product)null);

            ProductController productController = new ProductController(productServiceMock.Object);

            // Act & Assert
            productController
                 .WithCallTo(c => c.ProductDetails(ProductId))
                     .ShouldRenderView("ProductNotFound");
        }

        [Test]
        public void ReturnViewWithEmptyModel_WhenParameterIsNull()
        {
            // Arrange
            var productServiceMock = new Mock<IProductService>();

            var productViewModel = new ProductDetailsViewModel();
            productServiceMock.Setup(m => m.GetById(null)).Returns((Product)null);

            ProductController productController = new ProductController(productServiceMock.Object);

            // Act & Assert
            productController
                 .WithCallTo(c => c.ProductDetails(null))
                     .ShouldRenderView("ProductNotFound");
        }
    }
}

