using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.CategoryTests
{
    public class ProductsCollection_Should
    {
        [TestCase(17)]
        [TestCase(26)]
        public void VehicleModelsCollection_ShouldGetAndSetDataCorrectly(int testId)
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
