using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class Cart
    {
        public Cart()
        {
            Products = new List<Product>();
        }

        public int Discount { get; set; }
        public List<Product> Products { get; set; }

        /// <summary>
        /// Add a new product to the cart
        /// </summary>
        /// <param name="product">Product object to add to Cart list</param>
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        /// <summary>
        /// Add/append a product list to the cart
        /// </summary>
        /// <param name="products">Product list to add/append to Cart list</param>
        public void AddProduct(List<Product> products)
        {
            Products.AddRange(products);
        }

        /// <summary>
        /// Displays all the items from the cart with their prices
        /// Should be optimised - https://stackoverflow.com/questions/52927/console-writeline-and-generic-list
        /// </summary>
        public void DisplayCart()
        {
            Products.ForEach(p => Console.WriteLine($"{p.Name}: {p.Cost} {p.Currency}"));
        }

        /// <summary>
        /// Calculates total cart cost
        /// </summary>
        /// <returns>Total cart cost</returns>
        public decimal CalculateTotal()
        {
            var total = 0m;

            Products.ForEach(p => total += p.Cost);

            return total;
        }
    }
}
