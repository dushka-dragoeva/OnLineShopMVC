using System.ComponentModel.DataAnnotations;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Tests.ProductTests
{
    public class ProductQuantity_Should
    {
        [Test]
        public void HaveRequiredAttribute()
        {
            // Arrange
            var quantityProperty = typeof(Product).GetProperty("Quantity");

            // Act
            var requiredAttribute = quantityProperty.GetCustomAttributes(typeof(RequiredAttribute), true)
                .Cast<RequiredAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(requiredAttribute, Is.Not.Null);
        }


        [Test]
        public void HaveCorrectRangeAttributeMinimum()
        {
            // Arrange
            var quantityProperty = typeof(Product).GetProperty("Quantity");

            // Act
            var rangeAttribute = quantityProperty.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.RangeAttribute), false)
                .Cast<System.ComponentModel.DataAnnotations.RangeAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(rangeAttribute.Minimum, Is.Not.Null.And.EqualTo(ValidationConstants.QuantityMinValue));
        }

        [Test]
        public void HaveCorrectRangeAttributeMaximum()
        {
            // Arrange
            var quantityProperty = typeof(Product).GetProperty("Quantity");

            // Act
            var rangeAttribute = quantityProperty.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.RangeAttribute), false)
                .Cast<System.ComponentModel.DataAnnotations.RangeAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(rangeAttribute.Maximum, Is.Not.Null.And.EqualTo(ValidationConstants.QuantityMaxValue));
        }

        [Test]
        public void HaveCorrectRangeErrorMessage()
        {
            // 
            var quantityProperty = typeof(Product).GetProperty("Quantity");

            // Act
            var rangeAttribute = quantityProperty.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.RangeAttribute), false)
                .Cast<System.ComponentModel.DataAnnotations.RangeAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(rangeAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.QuаntityOutOfRangeErrorMessage));
        }

       
        [TestCase(33)]
        [TestCase(169)]
        public void GetAndSetDataCorrectly(int testQuantity)
        {
            // Arrange & Act
            var product = new Product() { Quantity = testQuantity };

            // Assert
            Assert.AreEqual(product.Quantity, testQuantity);
        }
    }
}
