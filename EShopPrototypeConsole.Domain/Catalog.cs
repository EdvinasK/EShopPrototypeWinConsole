using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class Catalog
    {
        public int Id { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
