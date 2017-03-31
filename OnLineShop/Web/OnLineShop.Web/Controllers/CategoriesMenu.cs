using OnLineShop.Data;
using OnLineShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnLineShop.Web.Controllers
{
    public class CategoriesMenu
    {
        public static List<Category> GetMenus()
        {
            using (var categoryService = new OnLineShopDbContext())
            {
                return categoryService.Categories.ToList();
            }
        }
    }
}