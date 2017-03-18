using System.ComponentModel.DataAnnotations;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.ProductTests
{
    public class ProductId_Should
    {
        [Test]
        public void HaveKeyAttribute()
        {
            // Arrange
            var idProperty = typeof(Product).GetProperty("Id");

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
            var product = new Product() { Id = testId };

            // Assert
            Assert.AreEqual(testId, product.Id);
        }
    }
}
