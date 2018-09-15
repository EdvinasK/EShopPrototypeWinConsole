using System;
using EShopPrototypeConsole.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EShopPrototypeConsole.DomainTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void CalculateDiscount_ValidDiscount_Success()
        {
            // Arrange
            var product = new Product("TestProduct", 10m)
            {
                Discount = 10
            };

            var expected = 9m;

            // Act
            var actual = product.CalculateDiscount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDiscount_NoDiscount_Success()
        {
            // Arrange
            var product = new Product("TestProduct", 10m);

            var expected = 10m;

            // Act
            var actual = product.CalculateDiscount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDiscount_NegativeDiscount_Success()
        {
            // Arrange
            var product = new Product("TestProduct", 10m)
            {
                Discount = -50
            };

            var expected = 10m;

            // Act
            var actual = product.CalculateDiscount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetProviderInfo_NullProvider_Success()
        {
            // Arrange
            var product = new Product("TestProduct", 10m);

            string expected = null;

            // Act
            var actual = product.GetProviderInfo();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetProviderInfo_NamedProvider_Success()
        {
            // Arrange
            var product = new Product("TestProduct", 10m);
            product.Provider.Name = "Samsong";

            var expected = "Samsong";

            // Act
            var actual = product.GetProviderInfo();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
