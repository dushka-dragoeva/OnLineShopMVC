using System.Collections.Generic;
using System.Linq;

using OnLineShop.Data.Models;
using OnLineShop.Web.Models.Products;

namespace OnLineShop.Web.Models.Categories
{
    public class CategoryDetailsViewModel 
    {
        public CategoryDetailsViewModel()
        {
        }

        public CategoryDetailsViewModel(Category category)
        {
            if (category != null)
            {
                this.Id = category.Id;
                this.Name = category.Name;
                this.Products = category.Products.Select(p => new ProductsViewModel(p)).ToList();
            }
        }

        public int Id { get; private set; }

        public string Name { get; set; }

        public IEnumerable<ProductsViewModel> Products { get; set; }
    }
}