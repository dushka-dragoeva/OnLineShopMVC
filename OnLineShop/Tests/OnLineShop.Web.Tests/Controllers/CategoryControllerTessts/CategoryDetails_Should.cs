using System.Linq;

using Moq;
using NUnit.Framework;
using TestStack.FluentMVCTesting;

using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Controllers;
using OnLineShop.Web.Models.Categories;


namespace OnLineShop.Web.Tests.Controllers.CategoryControllerTessts
{
    [TestFixture]
    public class CategoryDetails_Should
    {
        [Test]
        public void ReturnViewWithModelWithCorrectProperties_WhenThereIsAModelWithThePassedId()
        {
            // Arrange
            var categoryServiceMock = new Mock<ICategoryService>();

            var category = new Category()
            {
                Id = 5,
                Name = "Рокли",
            };

            Product product = new Product()
            {
                Id = 5,
                Name = "Рокля на цветя",
                ModelNumber = "123",
                Quantity = 5,
                Category = category,
                PictureUrl = "www.go.home",
                Price = 55.20m,
                Brand = new Brand()
                {
                    Id = 1,
                    Name = "Levis"
                }
            };

            category.Products.Add(product);

            var categoryViewModel = new CategoryDetailsViewModel(category);

            categoryServiceMock.Setup(m => m.GetById(category.Id)).Returns(category);

            CategoryController categoryController = new CategoryController(categoryServiceMock.Object);

            // Act & Assert
            categoryController
                .WithCallTo(c => c.CategoryDetails(category.Id))
                    .ShouldRenderDefaultView()
                    .WithModel<CategoryDetailsViewModel>(viewModel =>
                    {
                        Assert.AreEqual(category.Id, viewModel.Id);
                        Assert.AreEqual(category.Name, viewModel.Name);
                        Assert.AreEqual(category.Products.Count, viewModel.Products.Count());
                    });
        }

        [Test]
        public void ReturnViewWithEmptyModel_WhenThereNoModelWithThePassedId()
        {
            // Arrange
            var categoryServiceMock = new Mock<ICategoryService>();

            var categoryViewModel = new CategoryDetailsViewModel();
            int? categoryId = 5;
            categoryServiceMock.Setup(m => m.GetById(categoryId)).Returns((Category)null);

            CategoryController categoryController = new CategoryController(categoryServiceMock.Object);

            // Act & Assert
            categoryController
                .WithCallTo(c => c.CategoryDetails(categoryId))
                    .ShouldRenderView("CategoryNotFound");
        }

        [Test]
        public void ReturnViewWithEmptyModel_WhenParameterIsNull()
        {
            // Arrange
            var categoryServiceMock = new Mock<ICategoryService>();

            var categoryViewModel = new CategoryDetailsViewModel();
            categoryServiceMock.Setup(m => m.GetById(null)).Returns((Category)null);

            CategoryController categoryController = new CategoryController(categoryServiceMock.Object);

            // Act & Assert
            categoryController
                .WithCallTo(c => c.CategoryDetails(null))
                .ShouldRenderView("CategoryNotFound");
        }
    }
}
