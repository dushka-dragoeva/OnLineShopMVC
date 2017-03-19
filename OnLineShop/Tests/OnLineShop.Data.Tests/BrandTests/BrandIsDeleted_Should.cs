using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.BrandTests
{
    public class BrandIsDeleted_Should
    {

        [TestCase(true)]
        [TestCase(false)]
        public void IsDeleted_ShouldGetAndSetDataCorrectly(bool testIsDeleted)
        {
            // Arrange & Act
            var brand = new Brand { IsDeleted = testIsDeleted };

            // Assert
            Assert.AreEqual(testIsDeleted, brand.IsDeleted);
        }
    }
}
