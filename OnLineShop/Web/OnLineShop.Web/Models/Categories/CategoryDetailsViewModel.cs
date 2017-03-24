using OnLineShop.Web.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShop.Web.Models.Categories
{
    public class CategoryDetailsViewModel : CategoriesNavigationViewModel
    {
        public ICollection<ProductsViewModel> Products { get; set; }
    }
}