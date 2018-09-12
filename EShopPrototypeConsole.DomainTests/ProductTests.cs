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
    }
}
