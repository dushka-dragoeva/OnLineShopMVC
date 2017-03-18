using System.Collections.Generic;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.ProductTests
{
    public class ProductConstructor_Should
    {
        [Test]
        public void HaveParameterlessConstructor()
        {
            // Arrange & Act
            var product = new Product();

            // Assert
            Assert.IsInstanceOf<Product>(product);
        }

        [Test]
        public void InitializesizeCollectionCorrectly()
        {
            // Arrange & Act
            var product = new Product();
            var products = product.Sizes;

            // Assert
            Assert.That(products, Is.Not.Null.And.InstanceOf<HashSet<Size>>());
        }
    }
}
