﻿using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.SizeTests
{
    public class SizeProductsCollection_Should
    {
        [TestCase(17)]
        [TestCase(26)]
        public void GetAndSetDataCorrectly(int testId)
        {
            // Arrange & Act
            var product = new Product() { Id = testId };
            var set = new HashSet<Product> { product };
            var size = new Size() { Products = set };

            // Assert
            Assert.AreEqual(size.Products.First().Id, testId);
        }
    }
}

