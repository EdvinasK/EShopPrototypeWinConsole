using EShopPrototypeConsole.Domain;
using System;
using System.Collections.Generic;

namespace EShopPrototypeConsole.Data
{
    public class CartRepository
    {
        public CartRepository()
        {
            Carts = new List<Cart>();
        }

        public ICollection<Cart> Carts { get; set; }
    }
}
