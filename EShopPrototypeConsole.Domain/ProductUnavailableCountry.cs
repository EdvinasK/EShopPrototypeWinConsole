using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class ProductUnavailableCountry
    {
        #region Constructors
        public ProductUnavailableCountry()
        {
            Countries = new Collection<Country>();
            Products = new Collection<Product>();
        }
        #endregion
        public int Id { get; set; }
        public int CountryId { get; set; }
        public ICollection<Country> Countries { get; set; }
        public int ProductId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
