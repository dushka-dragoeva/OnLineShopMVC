using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Tests.ProductTests
{
    public class ModelNumber_Should
    {
        [Test]
        public void HaveRequiredAttribute()
        {
            // Arrange
            var modelNumberProperty = typeof(Product).GetProperty("ModelNumber");

            // Act
            var requiredAttribute = modelNumberProperty.GetCustomAttributes(typeof(RequiredAttribute), true)
                .Cast<RequiredAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void HaveCorrectMinLength()
        {
            // Arrange
            var modelNumberProperty = typeof(Product).GetProperty("ModelNumber");

            // Act
            var minLengthAttribute = modelNumberProperty.GetCustomAttributes(typeof(MinLengthAttribute), false)
                .Cast<MinLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(minLengthAttribute.Length, Is.Not.Null.And.EqualTo(ValidationConstants.StandardMinLength));
        }

        [Test]
        public void HaveCorrectMinLengthErrorMessage()
        {
            // Arrange
            var modelNumberProperty = typeof(Product).GetProperty("ModelNumber");

            // Act
            var minLengthAttribute = modelNumberProperty.GetCustomAttributes(typeof(MinLengthAttribute), false)
                .Cast<MinLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(minLengthAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.MinLengthFieldErrorMessage));
        }

        [Test]
        public void HaveCorrectMaxLength()
        {
            // Arrange
            var modelNumberProperty = typeof(Product).GetProperty("ModelNumber");

            // Act
            var maxLengthAttribute = modelNumberProperty.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(maxLengthAttribute.Length, Is.Not.Null.And.EqualTo(ValidationConstants.StandartMaxLength));
        }

        [Test]
        public void HaveCorrectMaxLengthErrorMessage()
        {
            // Arrange
            var modelNumberProperty = typeof(Product).GetProperty("ModelNumber");

            // Act
            var maxLengthAttribute = modelNumberProperty.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(maxLengthAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.MaxLengthFieldErrorMessage));
        }

        [Test]
        public void HaveCorrectRegularExpression()
        {
            // Arrange
            var modelNumberProperty = typeof(Product).GetProperty("ModelNumber");

            // Act
            var regularExpressionAttribute = modelNumberProperty.GetCustomAttributes(typeof(RegularExpressionAttribute), false)
                .Cast<RegularExpressionAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(regularExpressionAttribute.Pattern, Is.Not.Null.And.EqualTo(ValidationConstants.DescriptionRegex));
        }

        [Test]
        public void HaveCorrectRegularExpressionErrorMessage()
        {
            // Arrange
            var modelNumberProperty = typeof(Product).GetProperty("ModelNumber");

            // Act
            var regularExpressionAttribute = modelNumberProperty.GetCustomAttributes(typeof(RegularExpressionAttribute), false)
               .Cast<RegularExpressionAttribute>()
               .FirstOrDefault();

            // Assert
            Assert.That(regularExpressionAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.NotAllowedSymbolsErrorMessage));
        }

        [TestCase("136AX")]
        [TestCase("ARTG")]
        public void GetAndSetDataCorrectly(string testModelNumber)
        {
            // Arrange & Act
            var product = new Product() { ModelNumber = testModelNumber };

            // Assert
            Assert.AreEqual(product.ModelNumber, testModelNumber);
        }
    }
}

