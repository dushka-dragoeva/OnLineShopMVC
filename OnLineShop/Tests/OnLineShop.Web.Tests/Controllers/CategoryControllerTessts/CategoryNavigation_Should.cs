using System.Collections.Generic;

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
    public class CategoryNavigation_Should
    {
        [Test]
        public void ReturnPartialViewWithCattegories_WhenPassedPatameterIsNotEmptyCollection()
        {
            // Arrange
            var categoryService = new Mock<ICategoryService>();

            Category first = new Category() { Name = "Рокли" };
            Category second = new Category() { Name = "Поли" };

            var categoryList = new List<Category>() { first, second } ;

            categoryService.Setup(c => c.GetAll()).Returns(categoryList);
           
            // Act
            var categoryController = new CategoryController(categoryService.Object) ;

           //  Assert
            categoryController
                .WithCallTo(c => c.CategoriesNavigation())
                .ShouldRenderPartialView("_CategoriesPartial")
                .WithModel<IEnumerable<CategoriesNavigationViewModel>>();
        }

        [Test]
        public void ReturnEmptyPartialView_WhenPassedPatameterIsEmptyCollection()
        {
            // Arrange
            var categoryService = new Mock<ICategoryService>();
            IEnumerable<Category> categoryList = new List<Category>();

            categoryService.Setup(c => c.GetAll()).Returns(categoryList);

            // Act
            var categoryController = new CategoryController(categoryService.Object);

            //  Assert
            categoryController
                .WithCallTo(c => c.CategoriesNavigation())
                .ShouldRenderPartialView("_CategoriesPartial");
        }
    }
}
