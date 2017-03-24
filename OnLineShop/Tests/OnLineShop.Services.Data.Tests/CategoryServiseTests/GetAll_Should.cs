using Moq;
using NUnit.Framework;
using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnLineShop.Services.Data.Tests.CategoryServiseTests
{
    [TestFixture]
    public class GetAll_Should
    {
        [Test]
        public void BeCalled_WhenParamsAreValid()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            CategoryService categoryService = new CategoryService(wrapperMock.Object, dbContextMock.Object);

            // Act
            categoryService.GetAll();

            // Assert
            wrapperMock.Verify(rep => rep.All(), Times.Once);
        }

        [Test]
        public void NotBeCalled_IfItIsNeverCalled()
        {
            // Arrange & Act
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            // Assert
            wrapperMock.Verify(rep => rep.All(), Times.Never);
        }

        [Test]
        public void ReturnIQueryable_IfCalled()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            CategoryService categoryService = new CategoryService(wrapperMock.Object, dbContextMock.Object);

            // Act
            IEnumerable<Category> expectedCategoriesResult = new List<Category>() { new Category(), new Category() };
            wrapperMock.Setup(rep => rep.All()).Returns(() => expectedCategoriesResult.AsQueryable());


            // Assert
            Assert.IsInstanceOf<IQueryable<Category>>(categoryService.GetAll());
        }

        [Test]
        public void ReturnCorrectCollection_IfCalled()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Category>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            CategoryService categoryService = new CategoryService(wrapperMock.Object, dbContextMock.Object);

            // Act
            IEnumerable<Category> expectedCategoriesResult = new List<Category>() { new Category(), new Category() };
            wrapperMock.Setup(rep => rep.All()).Returns(() => expectedCategoriesResult.AsQueryable());

            // Assert
            Assert.AreEqual(categoryService.GetAll(), expectedCategoriesResult);
        }
    }
}
