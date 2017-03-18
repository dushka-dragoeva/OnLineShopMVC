using System.Collections.Generic;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.BrandTests
{
    public class BrandConstructor_Should
    {
        [Test]
        public void HaveParameterlessConstructor()
        {
            // Arrange & Act
            var brand = new Brand();

            // Assert
            Assert.IsInstanceOf<Brand>(brand);
        }

        [Test]
        public void InitializeProductCollectionCorrectly()
        {
            // Arrange & Act
            var brand = new Brand();
            var products = brand.Products;

            // Assert
            Assert.That(products, Is.Not.Null.And.InstanceOf<HashSet<Product>>());
        }
    }
}
