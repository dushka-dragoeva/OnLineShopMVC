using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Moq;

using OnLineShop.Data.Contracts;
using OnLineShop.Data.Models;


namespace OnLineShop.Data.Tests.EfDbSetWrapper.Tests
{
    [TestFixture]
    public class All_Should
    {
        [Test]
        public void ReturnEntitiesOfGivenSet()
        {
            // Arrange
            var mockedDbContext = new Mock<IOnLineShopDbContext>();
            var mockedSet = new Mock<DbSet<Category>>();

            // Act
            mockedDbContext.Setup(x => x.Set<Category>()).Returns(mockedSet.Object);
            var mockedDbSet = new EfDbSetWrapper<Category>(mockedDbContext.Object);

            // Assert
            Assert.NotNull(mockedDbSet.All());
            Assert.IsInstanceOf(typeof(DbSet<Category>), mockedDbSet.All());
            Assert.AreSame(mockedDbSet.All(), mockedDbSet.DbSet);
        }
    }
}
