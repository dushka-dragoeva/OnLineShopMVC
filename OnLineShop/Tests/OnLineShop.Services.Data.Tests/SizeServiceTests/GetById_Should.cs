using Moq;
using NUnit.Framework;

using OnLineShop.Data.Models;
using OnLineShop.Services.Data;
using OnLineShop.Data.Contracts;

namespace OnLineShop.Services.Tests.SizeServiceTests
{
    [TestFixture]
    public class GetById_Should
    {
        [Test]
        public void ReturnSize_WhenIdIsValid()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Size>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            int sizeId = 1;
            Size size = new Size() { Id = sizeId, Value = "Size 1" };

            wrapperMock.Setup(m => m.GetById(sizeId)).Returns(size);

            SizeService sizeService = new SizeService(wrapperMock.Object, dbContextMock.Object);


            // Act
            Size SizeResult = sizeService.GetById(sizeId);

            // Assert
            Assert.AreSame(size, SizeResult);
        }

        [Test]
        public void ReturnNull_WhenIdParameterIsNull()
        {
            // Arrange

            var wrapperMock = new Mock<IEfDbSetWrapper<Size>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            SizeService SizeService = new SizeService(wrapperMock.Object, dbContextMock.Object);

            // Act
            Size SizeResult = SizeService.GetById(null);

            // Assert
            Assert.IsNull(SizeResult);
        }
    }
}

