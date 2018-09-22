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

        [TestMethod]
        public void CalculateProductVatCost_VatProvided_Success()
        {
            // Arrange
            var product = new Product("TestProduct", 10m)
            {
                Vat = 21
            };

            var expected = 2.1m;

            // Act
            var actual = product.CalculateProductVatCost();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateProductVatCost_NoVatProvided_Success()
        {
            // Arrange
            var product = new Product("TestProduct", 10m);

            var expected = 0;

            // Act
            var actual = product.CalculateProductVatCost();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTotalProductCost_DiscountVatProvided_Success()
        {
            // Arrange
            var product = new Product("TestProduct", 10m)
            {
                Discount = 10,
                Vat = 21
            };

            var expected = 10.89m;

            // Act
            var actual = product.CalculateTotalProductCost();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsProductAvailable_EmptyStock_Success()
        {
            // Arrange
            var cart = new Cart();
            var product = new Product("TestProduct", 10m);
            var productExtra = new ProductExtra(product)
            {
                Quantity = 0
            };
            product.ProductExtra = productExtra;

            var expected = "Product out of stock";

            // Act
            var actual = cart.AddProduct(product).Message; ;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsProductAvailable_LimitedStock_Success()
        {
            // Arrange
            var cart = new Cart();
            var product1 = new Product("Test1Product", 10m);
            var product2 = new Product("Test2Product", 10m);
            var productExtra = new ProductExtra(product1)
            {
                Quantity = 1
            };
            product1.ProductExtra = productExtra;
            product2.ProductExtra = productExtra;

            var expected = "Product out of stock";
            cart.AddProduct(product1);

            // Act
            var actual = cart.AddProduct(product2).Message; ;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
