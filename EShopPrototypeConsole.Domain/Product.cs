using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class Product
    {
        #region Constructor Region
        /// <summary>
        /// Create a product with default name and specified cost.
        /// </summary>
        /// <param name="cost">The cost or the price of the product ex: 99.99m</param>
        /// <returns>Returns a new product with specified cost and default name</returns>
        public Product(decimal cost)
        {
            Cost = cost;
            Provider = new Provider();
            ProductExtra = new ProductExtra();
        }

        /// <summary>
        /// Create a product with specified name and cost.
        /// </summary>
        /// <param name="name">Name or the title of the product ex: "Samsung S8"</param>
        /// <param name="cost">The cost or the price of the product ex: 99.99m</param>
        /// <returns>Returns a new product with specified cost and name</returns>
        public Product(string name, decimal cost) : this(cost)
        {
            Name = name;
        }
        #endregion

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Currency { get; set; } = "Eur";
        public int Vat { get; set; }
        public Provider Provider { get; set; }
        public ProductCategory Category { get; set; }
        public ProductExtra ProductExtra { get; set; }
        public int Discount { get; set; }


        /// <summary>
        /// Displays product name and cost
        /// </summary>
        public void DisplayProduct()
        {
            Console.WriteLine($"{Name}: {Cost}");
        }

        /// <summary>
        /// Calculates product vat(value added tax) cost
        /// </summary>
        /// <returns>Returns products vat cost ex: 100*21%</returns>
        public decimal CalculateProductVatCost()
        {
            return CalculateDiscount() * Vat / 100;
        }

        /// <summary>
        /// Calculates discounted price for a product
        /// </summary>
        /// <returns>Discounted price</returns>
        public decimal CalculateDiscount()
        {
            var discount = (Discount < 0) ? 0 : Discount;

            return Cost - (Cost * discount / 100);
        }

        /// <summary>
        /// Calculates total product cost including discount and vat
        /// </summary>
        /// <returns>Returns price-discount*vat</returns>
        public decimal CalculateTotalProductCost()
        {
            return CalculateDiscount() + CalculateProductVatCost();
        }

        /// <summary>
        /// Method used to return a trimed product name
        /// </summary>
        /// <returns>Returns a trimed product name</returns>
        public string GetProductName()
        {
            var name = Name.Trim();

            return name;
        }

        /// <summary>
        /// Method used to return provider information
        /// </summary>
        /// <returns>Returns provider information</returns>
        public string GetProviderInfo()
        {
            var name = Provider?.Name;

            return name;
        }
    }
}
