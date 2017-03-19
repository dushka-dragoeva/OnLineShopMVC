using NUnit.Framework;
using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.CategoryTests
{

    public class CategoryIsDeleted_Should
    {
        [TestCase(true)]
        [TestCase(false)]
        public void IsDeleted_ShouldGetAndSetDataCorrectly(bool testIsDeleted)
        {
            // Arrange & Act
            var category = new Category { IsDeleted = testIsDeleted };

            // Assert
            Assert.AreEqual(testIsDeleted, category.IsDeleted);
        }
    }
}
