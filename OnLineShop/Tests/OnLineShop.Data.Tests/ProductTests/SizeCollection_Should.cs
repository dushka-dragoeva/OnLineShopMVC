using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.CategoryTests
{
    public class ProductProductsCollection_Should
    {
        [TestCase(17)]
        [TestCase(26)]
        public void GetAndSetDataCorrectly(int testId)
        {
            // Arrange & Act
            var size = new Size() { Id = testId };
            var set = new HashSet<Size> { size };
            var product = new Product() { Sizes = set };

            // Assert
            Assert.AreEqual(product.Sizes.First().Id, testId);
        }
    }
}

