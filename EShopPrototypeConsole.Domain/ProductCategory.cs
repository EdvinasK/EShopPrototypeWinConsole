using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopPrototypeConsole.Domain
{
    public class ProductCategory
    {
        #region Constructors
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        #endregion

        #region Fields and properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public string FullDescription => $"{Name} - {Description}";
        //public string FullDescription
        //{
        //    get
        //    {
        //        return $"{Name} - {Description}";
        //    }
        //}

        #endregion

        #region Methods
        public List<Product> GetAllRequestedCategoryProducts()
        {
            return Products.ToList();
        }
        #endregion
    }
}
