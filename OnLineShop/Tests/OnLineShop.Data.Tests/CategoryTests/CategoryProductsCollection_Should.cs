using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.CategoryTests
{
    public class CategoryProductsCollection_Should
    {
        [TestCase(17)]
        [TestCase(26)]
        public void GetAndSetDataCorrectly(int testId)
        {
            // Arrange & Act
            var product = new Product() { Id = testId };
            var set = new HashSet<Product> { product };
            var category = new Category() { Products = set };

            // Assert
            Assert.AreEqual(category.Products.First().Id, testId);
        }
    }
}
