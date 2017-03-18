using System.ComponentModel.DataAnnotations;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Tests.ProductTests
{
    public class ProductDescription_Should
    {
        [Test]
        public void HaveCorrectMinLength()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Description");

            // Act
            var minLengthAttribute = nameProperty.GetCustomAttributes(typeof(MinLengthAttribute), false)
                .Cast<MinLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(minLengthAttribute.Length, Is.Not.Null.And.EqualTo(ValidationConstants.DescriptionMinLength));
        }

        [Test]
        public void HaveCorrectMinLengthErrorMessage()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Description");

            // Act
            var minLengthAttribute = nameProperty.GetCustomAttributes(typeof(MinLengthAttribute), false)
                .Cast<MinLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(minLengthAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.MinLengthDescriptionErrorMessage));
        }

        [Test]
        public void HaveCorrectMaxLength()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Description");

            // Act
            var maxLengthAttribute = nameProperty.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(maxLengthAttribute.Length, Is.Not.Null.And.EqualTo(ValidationConstants.DescriptionMaxLength));
        }

        [Test]
        public void HaveCorrectMaxLengthErrorMessage()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Description");

            // Act
            var maxLengthAttribute = nameProperty.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(maxLengthAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.MaxLengthDescriptionErrorMessage));
        }

        [Test]
        public void HaveCorrectRegularExpression()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Description");

            // Act
            var regularExpressionAttribute = nameProperty.GetCustomAttributes(typeof(RegularExpressionAttribute), false)
                .Cast<RegularExpressionAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(regularExpressionAttribute.Pattern, Is.Not.Null.And.EqualTo(ValidationConstants.DescriptionRegex));
        }
                
        [TestCase("Lusy Portokala.")]
        [TestCase("Бай Митко e gotin!")]
        public void GetAndSetDataCorrectly(string testDescription)
        {
            // Arrange & Act
            var product = new Product() { Description = testDescription };

            // Assert
            Assert.AreEqual(product.Description, testDescription);
        }
    }
}
