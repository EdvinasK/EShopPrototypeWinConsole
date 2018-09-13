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

        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Default";
        public decimal Cost { get; set; }
        public string Currency { get; set; } = "Eur";
        public int Discount { get; set; }


        /// <summary>
        /// Displays product name and cost
        /// </summary>
        public void DisplayProduct()
        {
            Console.WriteLine($"{Name}: {Cost}");
        }

        /// <summary>
        /// Calculates discounted price for a product
        /// </summary>
        /// <returns>Discounted price</returns>
        public decimal CalculateDiscount()
        {
            return Cost - (Cost * Discount / 100);
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
    }
}
