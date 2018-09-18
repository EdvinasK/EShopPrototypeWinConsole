using System;
using System.Collections.Generic;
using EShopPrototypeConsole.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EShopPrototypeConsole.DomainTests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void CalculateTotalWithDiscount_NoDiscountNoVatProducts_Success()
        {
            // Arrange
            var cart = new Cart();
            var productList = new List<Product>()
            {
                new Product("TestProduct1", 10m),
                new Product("TestProduct2", 90m)
            };
            cart.AddProduct(productList);

            var expected = 100m;

            // Act
            var actual = cart.CalculateTotalWithDiscount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTotalWithDiscount_DiscountNoVatProducts_Success()
        {
            // Arrange
            var cart = new Cart();
            var productList = new List<Product>()
            {
                new Product("TestProduct1", 10m){ Discount = 10 },
                new Product("TestProduct2", 90m){ Discount = 10 }
            };
            cart.AddProduct(productList);

            var expected = 90m;

            // Act
            var actual = cart.CalculateTotalWithDiscount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTotalWithDiscount_DiscountVatProducts_Success()
        {
            // Arrange
            var cart = new Cart();
            var productList = new List<Product>()
            {
                new Product("TestProduct1", 10m){ Discount=10, Vat=21 },
                new Product("TestProduct2", 90m){ Discount=10, Vat=21 }
            };
            cart.AddProduct(productList);

            var expected = 108.9m;

            // Act
            var actual = cart.CalculateTotalWithDiscount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTotalWithDiscount_DiscountVatProductsDiscountedCart_Success()
        {
            // Arrange
            var cart = new Cart()
            {
                Discount = 10
            };
            var productList = new List<Product>()
            {
                new Product("TestProduct1", 10m){ Discount=10, Vat=21 },
                new Product("TestProduct2", 90m){ Discount=10, Vat=21 }
            };
            cart.AddProduct(productList);

            var expected = 98.01m;

            // Act
            var actual = cart.CalculateTotalWithDiscount();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
