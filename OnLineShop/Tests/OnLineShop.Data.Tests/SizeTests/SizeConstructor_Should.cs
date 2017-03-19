using System.Collections.Generic;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.SizeTests
{
    public class SizeConstructor_Should
    {
        [Test]
        public void HaveParameterlessConstructor()
        {
            // Arrange & Act
            var size = new Size();

            // Assert
            Assert.IsInstanceOf<Size>(size);
        }

        [Test]
        public void InitializeProductCollectionCorrectly()
        {
            // Arrange & Act
            var size = new Size();
            var products = size.Products;

            // Assert
            Assert.That(products, Is.Not.Null.And.InstanceOf<HashSet<Product>>());
        }
    }
}
