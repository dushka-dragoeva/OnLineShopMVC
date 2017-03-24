using NUnit.Framework;

using OnLineShop.Data;
using OnLineShop.Data.Contracts;

namespace OnLineShop.Data.Tests.OnLineDbContextTests
{
    public class Create_Should
    {
        [Test]
        public void Create_Should_ReturnNewDbContextInstance()
        {
            // Arrange & Act
            var newContext = Data.OnLineShopDbContext.Create();

            // Assert
            Assert.IsNotNull(newContext);
            Assert.IsInstanceOf<IOnLineShopDbContext>(newContext);
        }
    }
}
