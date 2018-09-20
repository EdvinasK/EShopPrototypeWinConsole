using EShopPrototypeConsole.Domain;
using EShopPrototypeConsole.Domain.DataLayerAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShopPrototypeConsole.Data
{
    public class CartRepository : ICartRepository
    {
        public CartRepository()
        {
            Carts = new List<Cart>();
        }

        public ICollection<Cart> Carts { get; set; }

        public List<Product> GetAllCartProducts(int CartId)
        {
            return Carts.Where(c => c.Id == CartId).SingleOrDefault().Products.ToList();
        }

        public int GetCartProductCount(int CartId)
        {
            return Carts.Where(c => c.Id == CartId).SingleOrDefault().Products.Count();
        }
    }
}
