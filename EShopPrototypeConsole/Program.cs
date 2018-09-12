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

            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }
}
