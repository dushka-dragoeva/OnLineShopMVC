using System.ComponentModel.DataAnnotations;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;
using OnLineShop.Common.Constants;
using System;

namespace OnLineShop.Data.Tests.ProductTests
{
    public class ProductPrice_Should
    {
        [Test]
        public void HaveRequiredAttribute()
        {
            // Arrange
            var priceProperty = typeof(Product).GetProperty("Price");

            // Act
            var requiredAttribute = priceProperty.GetCustomAttributes(typeof(RequiredAttribute), true)
                .Cast<RequiredAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(requiredAttribute, Is.Not.Null);
        }


        [Test]
        public void HaveCorrectRangeAttributeMinimum()
        {
            // Arrange
            var priceProperty = typeof(Product).GetProperty("Price");

            // Act
            var rangeAttribute = priceProperty.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.RangeAttribute), false)
                .Cast<System.ComponentModel.DataAnnotations.RangeAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(rangeAttribute.Minimum, Is.Not.Null.And.EqualTo(ValidationConstants.PriceMinValue));
        }

        [Test]
        public void HaveCorrectRangeAttributeMaximum()
        {
            // Arrange
            var priceProperty = typeof(Product).GetProperty("Price");

            // Act
            var rangeAttribute = priceProperty.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.RangeAttribute), false)
                .Cast<System.ComponentModel.DataAnnotations.RangeAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(rangeAttribute.Maximum, Is.Not.Null.And.EqualTo(ValidationConstants.PriceMaxValue));
        }

        [Test]
        public void HaveCorrectRangeAttributeType()
        {
            // Arrange
            var priceProperty = typeof(Product).GetProperty("Price");

            // Act
            var rangeAttribute = priceProperty.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.RangeAttribute), false)
                .Cast<System.ComponentModel.DataAnnotations.RangeAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(rangeAttribute.OperandType, Is.Not.Null);
            Assert.True(rangeAttribute.OperandType.ToString()=="System.Decimal");
        }

        [Test]
        public void HaveCorrectRangeErrorMessage()
        {
            // 
            var priceProperty = typeof(Product).GetProperty("Price");

            // Act
            var rangeAttribute = priceProperty.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.RangeAttribute), false)
                .Cast<System.ComponentModel.DataAnnotations.RangeAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(rangeAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.PriceOutOfRangeErrorMessage));
        }
       
        [TestCase(333.25)]
        [TestCase(169.69)]
        public void GetAndSetDataCorrectly(decimal testPrice)
        {
            // Arrange & Act
            var product = new Product() { Price = testPrice };

            // Assert
            Assert.AreEqual(product.Price, testPrice);
        }
    }
}

