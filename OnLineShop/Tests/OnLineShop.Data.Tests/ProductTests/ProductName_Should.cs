﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Tests.ProductTests
{
    public class ProductName_Should
    {
        [Test]
        public void HaveRequiredAttribute()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Name");

            // Act
            var requiredAttribute = nameProperty.GetCustomAttributes(typeof(RequiredAttribute), true)
                .Cast<RequiredAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(requiredAttribute, Is.Not.Null);
        }

        [Test]
        public void HaveUniqueAttribute()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Name");

            // Act
            var indexAttribute = nameProperty.GetCustomAttributes(typeof(IndexAttribute), true)
                .Cast<IndexAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(indexAttribute, Is.Not.Null);
            Assert.That(indexAttribute.IsUnique, Is.True);
        }

        [Test]
        public void HaveCorrectMinLength()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Name");

            // Act
            var minLengthAttribute = nameProperty.GetCustomAttributes(typeof(MinLengthAttribute), false)
                .Cast<MinLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(minLengthAttribute.Length, Is.Not.Null.And.EqualTo(ValidationConstants.NameMinLength));
        }

        [Test]
        public void HaveCorrectMinLengthErrorMessage()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Name");

            // Act
            var minLengthAttribute = nameProperty.GetCustomAttributes(typeof(MinLengthAttribute), false)
                .Cast<MinLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(minLengthAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.MinLengthFieldErrorMessage));
        }

        [Test]
        public void HaveCorrectMaxLength()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Name");

            // Act
            var maxLengthAttribute = nameProperty.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(maxLengthAttribute.Length, Is.Not.Null.And.EqualTo(ValidationConstants.NameMaxLength));
        }

        [Test]
        public void HaveCorrectMaxLengthErrorMessage()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Name");

            // Act
            var maxLengthAttribute = nameProperty.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(maxLengthAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.MaxLengthFieldErrorMessage));
        }

        [Test]
        public void HaveCorrectRegularExpression()
        {
            // Arrange
            var nameProperty = typeof(Product).GetProperty("Name");

            // Act
            var regularExpressionAttribute = nameProperty.GetCustomAttributes(typeof(RegularExpressionAttribute), false)
                .Cast<RegularExpressionAttribute>()
                .FirstOrDefault();

            // Assert
            Assert.That(regularExpressionAttribute.Pattern, Is.Not.Null.And.EqualTo(ValidationConstants.EnBgDigitSpaceMinus));
        }

        [Test]
        public void HaveCorrectRegularExpressionErrorMessage()
        {
            // Arrange
            var nameProperty = typeof(Category).GetProperty("Name");

            // Act
            var regularExpressionAttribute = nameProperty.GetCustomAttributes(typeof(RegularExpressionAttribute), false)
               .Cast<RegularExpressionAttribute>()
               .FirstOrDefault();

            // Assert
            Assert.That(regularExpressionAttribute.ErrorMessage, Is.Not.Null.And.EqualTo(ValidationConstants.NotAllowedSymbolsErrorMessage));
        }

        [TestCase("Къса Пола")]
        [TestCase("Бермуди")]
        public void GetAndSetDataCorrectly(string testName)
        {
            // Arrange & Act
            var product = new Product() { Name = testName };

            // Assert
            Assert.AreEqual(product.Name, testName);
        }
    }
}