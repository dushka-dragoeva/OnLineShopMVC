using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;
using System;
using System.Data.Entity;

using Moq;
using NUnit.Framework;

namespace OnLineShop.Data.Tests.EfDbSetWrapper.Tests
{
    [TestFixture]
    public class EfDbSetWrapperConstructor_Should

    {
        [Test]
        public void Constructor_Should_WorkCorrectly_IfDbContextPassedIsValid()
        {
            // Arrange
            var mockedDbContext = new Mock<IOnLineShopDbContext>();
            var mockedModel = new Mock<DbSet<Category>>();

            // Act
            mockedDbContext.Setup(x => x.Set<Category>()).Returns(mockedModel.Object);
            var mockedDbSet = new EfDbSetWrapper<Category>(mockedDbContext.Object);

            // Assert
            Assert.That(mockedDbSet, Is.Not.Null);
        }

        [Test]
        public void SetContextCorrectly_WhenValidArgumentsPassed()
        {
            // Arrange
            var mockedDbContext = new Mock<IOnLineShopDbContext>();
            var mockedModel = new Mock<DbSet<Category>>();

            // Act
            mockedDbContext.Setup(x => x.Set<Category>()).Returns(mockedModel.Object);
            var mockedDbSet = new EfDbSetWrapper<Category>(mockedDbContext.Object);

            // Assert
            Assert.That(mockedDbSet, Is.Not.Null);
            Assert.That(mockedDbSet.EfDbContext, Is.EqualTo(mockedDbContext.Object));
        }

        [Test]
        public void SetDbSetCorrectly_WhenValidArgumentsPassed()
        {
            // Arrange
            var mockedDbContext = new Mock<IOnLineShopDbContext>();
            var mockedModel = new Mock<DbSet<Category>>();

            // Act
            mockedDbContext.Setup(x => x.Set<Category>()).Returns(mockedModel.Object);
            var mockedDbSet = new EfDbSetWrapper<Category>(mockedDbContext.Object);

            // Assert
            Assert.That(mockedDbSet.DbSet, Is.Not.Null);
            Assert.That(mockedDbSet.DbSet, Is.EqualTo(mockedModel.Object));
        }

        [Test]
        public void ThrowArgumentNullException_IfDbContextPassedIsNull()
        {
            // Arrange
            IOnLineShopDbContext nullContext = null;

            // Act & Assert
            Assert.That(() => new EfDbSetWrapper<Category>(nullContext),
                Throws.InstanceOf<ArgumentNullException>().With.Message.Contains(nameof(IOnLineShopDbContext)));
        }
    }
}
