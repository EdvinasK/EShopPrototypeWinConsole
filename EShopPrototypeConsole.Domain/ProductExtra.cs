using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class ProductExtra
    {
        #region Constructors
        public ProductExtra()
        {
            Products = new HashSet<Product>();
        }

        public ProductExtra(Product product) : this()
        {
            Products.Add(product);
        }

        public ProductExtra(List<Product> products) : this()
        {
            Products = products;
        }
        #endregion

        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public string MadeIn { get; set; }
        public int Quantity { get; set; }
        public DateTime? AvailabilityDate { get; set; }
    }
}
