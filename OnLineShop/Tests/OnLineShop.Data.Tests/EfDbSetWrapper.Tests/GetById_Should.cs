using System.Data.Entity;

using Moq;
using NUnit.Framework;

using OnLineShop.Data.Models;
using OnLineShop.Data.Contracts;


namespace OnLineShop.Data.Tests.EfDbSetWrapper.Tests
{
    [TestFixture]
    public class GetById_Should
    {
        [Test]
        public void ReturnCorrectResult_WhenParameterIsValid()
        {
            // Arrange 
            var mockedDbContext = new Mock<IOnLineShopDbContext>();
            var mockedSet = new Mock<DbSet<Category>>();
            var fakeCategory = new Mock<Category>();
            var validId = 15;

            // Act
            mockedDbContext.Setup(x => x.Set<Category>()).Returns(mockedSet.Object);
            var mockedDbSet = new EfDbSetWrapper<Category>(mockedDbContext.Object);
            mockedSet.Setup(x => x.Find(It.IsAny<int>())).Returns(fakeCategory.Object);

            // Assert
            Assert.That(mockedDbSet.GetById(validId), Is.Not.Null);
            Assert.AreEqual(mockedDbSet.GetById(validId), fakeCategory.Object);
        }
    }
}
