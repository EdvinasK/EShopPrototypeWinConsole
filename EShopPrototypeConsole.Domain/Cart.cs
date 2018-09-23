using EShopPrototypeConsole.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class Cart
    {
        #region Constructor Region
        public Cart()
        {
            Products = new List<Product>();
        }
        #endregion

        public int Id { get; set; }
        public int Discount { get; set; }
        public List<Product> Products { get; set; }

        public enum IncludeDiscount { Included, Excluded };

        /// <summary>
        /// Add a new product to the cart
        /// </summary>
        /// <param name="product">Product object to add to Cart list</param>
        public OperationResult AddProduct(Product product)
        {
            return AddProduct(product, 1, null, IncludeDiscount.Included);

        }

        /// <summary>
        /// Add a number of new products to the cart
        /// </summary>
        /// <param name="product">Product object to add to Cart list</param>
        /// <param name="quantity">Quantity of the product to order</param>
        public OperationResult AddProduct(Product product, int quantity)
        {
            return AddProduct(product, quantity, null, IncludeDiscount.Included);

        }


        /// <summary>
        /// Add a number of new products to the cart with a delivery date
        /// </summary>
        /// <param name="product">Product object to add to Cart list</param>
        /// <param name="quantity">Quantity of the product to order</param>
        /// <param name="deliverBy">Requested delivery date</param>
        public OperationResult AddProduct(Product product, int quantity, DateTimeOffset? deliverBy)
        {
            return AddProduct(product, quantity, deliverBy, IncludeDiscount.Included);
        }

        /// <summary>
        /// Add a number of new products to the cart with a delivery date
        /// </summary>
        /// <param name="product">Product object to add to Cart list</param>
        /// <param name="quantity">Quantity of the product to order</param>
        /// <param name="deliverBy">Requested delivery date</param>
        /// <param name="includeDiscount">Should product have discount included</param>
        public OperationResult AddProduct(Product product, int quantity, DateTimeOffset? deliverBy, 
                                            IncludeDiscount includeDiscount)
        {
            // Guard clause
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            if (deliverBy <= DateTimeOffset.Now) throw new ArgumentOutOfRangeException(nameof(deliverBy));

            if (product.IsProductAvailable)
            {
                Products.Add(product);
                product.ProductExtra.Quantity--;
            }
            else
            {
                return new OperationResult(false, "Product out of stock");
            }

            return new OperationResult(true, "Product was added succesfuly");

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
        /// Calculates discounted total cost for the cart
        /// </summary>
        /// <param name="discount">Integer discount for the purchase cart/bag</param>
        /// <returns>Discounted total cost</returns>
        public decimal CalculateTotalWithDiscount()
        {
            var total = CalculateTotal();

            return total - (total * Discount / 100);
        }

        /// <summary>
        /// Calculates total cart cost
        /// </summary>
        /// <returns>Total cart cost</returns>
        public decimal CalculateTotal()
        {
            var total = 0m;

            Products.ForEach(p => total += p.CalculateTotalProductCost());

            return total;
        }
    }
}
