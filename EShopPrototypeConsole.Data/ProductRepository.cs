using EShopPrototypeConsole.Domain;
using EShopPrototypeConsole.Domain.DataLayerAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Data
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
            Products = new List<Product>();
        }

        public ICollection<Product> Products { get; set; }


    }
}
