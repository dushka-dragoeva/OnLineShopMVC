using Moq;
using NUnit.Framework;

using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data;

namespace OnLineShop.Services.Tests.BrandServiceTest
{
    [TestFixture]
    public class GetById_Should
    {
        [Test]
        public void ReturnBrand_WhenIdIsValid()
        {
            // Arrange
            var wrapperMock = new Mock<IEfDbSetWrapper<Brand>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();

            int brandId = 1;
            Brand brand = new Brand() { Id = brandId, Name="Levis"};

            wrapperMock.Setup(m => m.GetById(brandId)).Returns(brand);

            BrandService brandService = new BrandService(wrapperMock.Object, dbContextMock.Object);
            // Act
            Brand brandResult = brandService.GetById(brandId);

            // Assert
            Assert.AreSame(brand, brandResult);
        }

        [Test]
        public void ReturnNull_WhenIdParameterIsNull()
        {
            // Arrange

            var wrapperMock = new Mock<IEfDbSetWrapper<Brand>>();
            var dbContextMock = new Mock<IOnLineShopDbContextSaveChanges>();
            BrandService brandService = new BrandService(wrapperMock.Object, dbContextMock.Object);

            // Act
            Brand brandResult = brandService.GetById(null);

            // Assert
            Assert.IsNull(brandResult);
        }
    }
}

