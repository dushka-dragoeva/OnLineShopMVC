using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.ProductTests
{
    public  class ProductIsDeletedShould
    {
        [TestCase(true)]
        [TestCase(false)]
        public void IsDeleted_ShouldGetAndSetDataCorrectly(bool testIsDeleted)
        {
            // Arrange & Act
            var product = new Product { IsDeleted = testIsDeleted };

            // Assert
            Assert.AreEqual(testIsDeleted, product.IsDeleted);
        }
    }
}
