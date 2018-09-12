using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class Product
    {
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
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Default";
        public decimal Cost { get; set; }
    }
}
