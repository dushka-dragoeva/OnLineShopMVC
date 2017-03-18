using System.ComponentModel.DataAnnotations;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Tests.ProductTests
{
    public class ProductPictureUrl_Should
    {
        [Test]
        public void HaveCorrectMinLength()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("PictureUrl");

            // Act
            var minLengthAttribute = nameProperty.GetCustomAttributes(typeof(MinLengthAttribute), false)
                .Cast<MinLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(minLengthAttribute.Length, Is.Not.Null.And.EqualTo(ValidationConstants.ImageUrlMinLength));
        }

        [Test]
        public void HaveCorrectMinLengthErrorMessage()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("PictureUrl");

            // Act
            var minLengthAttribute = nameProperty.GetCustomAttributes(typeof(MinLengthAttribute), false)
                .Cast<MinLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(minLengthAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.MinLengthUrlErrorMessage));
        }

        [Test]
        public void HaveCorrectMaxLength()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("PictureUrl");

            // Act
            var maxLengthAttribute = nameProperty.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(maxLengthAttribute.Length, Is.Not.Null.And.EqualTo(ValidationConstants.ImageUrlMaxLength));
        }

        [Test]
        public void HaveCorrectMaxLengthErrorMessage()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("PictureUrl");

            // Act
            var maxLengthAttribute = nameProperty.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(maxLengthAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.MaxLengthUrlErrorMessage));
        }

        [TestCase("www.abv.bg")]
        [TestCase("Бай ")]
        public void GetAndSetDataCorrectly(string testPictureUrl)
        {
            // Arrange & Act
            var Product = new Product() { PictureUrl = testPictureUrl };

            // Assert
            Assert.AreEqual(Product.PictureUrl, testPictureUrl);
        }
    }
}