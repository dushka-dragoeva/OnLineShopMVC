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
        public void ReturnCategory_WhenThereIsAModelWithThePassedId()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            int categoryId = 1;

            wrapperMock.Setup(m => m.GetById(categoryId)).Returns(new Category() { Id = categoryId });

            CategoryService categoryService = new CategoryService(wrapperMock.Object, dbContextMock.Object);

            // Act
            Category category = categoryService.GetById(categoryId);

            // Assert
            Assert.IsNotNull(category);
        }

        [Test]
        public void ReturnNull_WhenIdParameterIsNull()
        {
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

