using NUnit.Framework;

using OnLineShop.Data;

namespace OnLineShop.Data.Tests.OnLineDbContextTests
{
    [TestFixture]
  public  class Constructor_Should
    {
        [Test]
        public void HaveParameterlessConstructor()
        {
            // Arrange & Act
            var context = new OnLineShopDbContext();

            // Assert
            Assert.IsInstanceOf<OnLineShopDbContext>(context);
        }

        [Test]
        public void Constructor_Should_Return_InstanceOfIPetsWonderlandDbContext()
        {
            // Arrange & Act
            var context = new Data.OnLineShopDbContext();

            // Assert
            Assert.IsInstanceOf<OnLineShopDbContext>(context);
        }
    }
}
