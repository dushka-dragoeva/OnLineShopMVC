using NUnit.Framework;
using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.SizeTests
{
    public   class SizeIzDeleted_Should
    {
        [TestCase(true)]
        [TestCase(false)]
        public void IsDeleted_ShouldGetAndSetDataCorrectly(bool testIsDeleted)
        {
            // Arrange & Act
            var size = new Size { IsDeleted = testIsDeleted };

            // Assert
            Assert.AreEqual(testIsDeleted, size.IsDeleted);
        }
    }
}
