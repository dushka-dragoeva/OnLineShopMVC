using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.BrandTests
{
    public class BrandProductsCollection_Should
    {
        [TestCase(17)]
        [TestCase(26)]
        public void GetAndSetDataCorrectly(int testId)
        {
            // Arrange & Act
            var product = new Product() { Id = testId };
            var set = new HashSet<Product> { product };
            var brand = new Brand() { Products = set };

            // Assert
            Assert.AreEqual(brand.Products.First().Id, testId);
        }
    }
}
