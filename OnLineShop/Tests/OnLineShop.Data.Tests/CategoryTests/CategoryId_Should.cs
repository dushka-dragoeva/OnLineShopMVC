using NUnit.Framework;
using OnLineShop.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OnLineShop.Data.Tests.CategoryTests
{
    public class CategoryId_Should
    {
        [Test]
        public void HaveKeyAttribute()
        {
            // Arrange
            var idProperty = typeof(Category).GetProperty("Id");

            // Act
            var keyAttribute = idProperty.GetCustomAttributes(typeof(KeyAttribute), true)
                .Cast<KeyAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(keyAttribute, Is.Not.Null);
        }

        [TestCase(17)]
        [TestCase(26)]
        public void GetAndSetDataCorrectly(int testId)
        {
            // Arrange & Act
            var category = new Category() { Id = testId };

            // Assert
            Assert.AreEqual(testId, category.Id);
        }
    }
}
