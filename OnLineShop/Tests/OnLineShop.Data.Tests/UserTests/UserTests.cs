using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using OnLineShop.Data.Models;

namespace CarSystem.Data.Models.Tests.UserTests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_ShouldHaveParametlessConstructor()
        {
            // Arrange & Act
            var user = new User();

            // Assert
            Assert.IsInstanceOf<User>(user);
        }

        [Test]
        public void Constructor_ShouldInitializecontactInfosCollectionCorreclty()
        {
            // Arrange & Act
            var user = new User();
            var contactInfos = user.ContactInfos;

            // Assert
            Assert.That(contactInfos, Is.Not.Null.And.InstanceOf<HashSet<ContactInfo>>());
        }

        [TestCase(true)]
        [TestCase(false)]
        public void IsDeleted_ShouldGetAndSetDataCorrectly(bool testIsDeleted)
        {
            // Arrange & Act
            var user = new User { IsDeleted = testIsDeleted };

            // Assert
            Assert.AreEqual(testIsDeleted, user.IsDeleted);
        }

        [TestCase(123)]
        [TestCase(12)]
        public void ContactInfosCollection_ShouldGetAndSetDataCorrectly(int testId)
        {
            // Arrange & Act
            var contactInfos = new ContactInfo() { Id = testId };
            var set = new HashSet<ContactInfo> { contactInfos };
            var user = new User() { ContactInfos = set };

            // Assert
            Assert.AreEqual(user.ContactInfos.First().Id, testId);
        }
    }
}

