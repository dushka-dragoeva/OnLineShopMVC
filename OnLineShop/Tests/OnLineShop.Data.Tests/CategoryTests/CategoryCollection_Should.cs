using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace OnLineShop.Data.Tests.CategoryTests
{
    public class CategoryCollection_Should
    {
        [TestCase(17)]
        [TestCase(26)]
        public void VehicleModelsCollection_ShouldGetAndSetDataCorrectly(int testId)
        {
            // Arrange & Act
            var subCategory = new Category() { Id = testId };
            var set = new HashSet<Category> { subCategory };
            var category = new Category() { SubCategories = set };

            // Assert
            Assert.AreEqual(category.SubCategories.First().Id, testId);
        }
    }
}
