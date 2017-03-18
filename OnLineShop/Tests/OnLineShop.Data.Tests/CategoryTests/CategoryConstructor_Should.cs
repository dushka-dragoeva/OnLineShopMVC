using System.Collections.Generic;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.CategoryTests
{
    public class Constructor_Should
    {
        [Test]
        public void HaveParameterlessConstructor()
        {
            // Arrange & Act
            var category = new Category();

            // Assert
            Assert.IsInstanceOf<Category>(category);
        }

        [Test]
        public void InitializeProductCollectionCorrectly()
        {
            // Arrange & Act
            var category = new Category();
            var products = category.Products;

            // Assert
            Assert.That(products, Is.Not.Null.And.InstanceOf<HashSet<Product>>());
        }

        [Test]
        public void InitializeCategoryCollectionCorrectly()
        {
            // Arrange & Act
            var category = new Category();
            var subCategories = category.SubCategories;

            // Assert
            Assert.That(subCategories, Is.Not.Null.And.InstanceOf<HashSet<Category>>());
        }
    }
}
