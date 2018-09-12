using EShopPrototypeConsole.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("TestProduct", 99.99m);
            var product2 = new Product("SecondTestProduct", 50.45m);
            var cart = new Cart();

            cart.AddProduct(product1);
            cart.AddProduct(product2);

            Console.WriteLine("Displaying product info:");
            product1.DisplayProduct();
            product2.DisplayProduct();

            Console.WriteLine("\n\nDisplaying cart info:");
            cart.DisplayCart();
            Console.WriteLine($"Total cost: {cart.CalculateTotal()} {product1.Currency}");

            Console.ReadLine();
        }
    }
}
