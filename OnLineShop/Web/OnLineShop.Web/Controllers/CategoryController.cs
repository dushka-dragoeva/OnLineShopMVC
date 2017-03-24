using System.Collections.Generic;
using System.Linq;

using System.Web.Mvc;

using OnLineShop.Common.Constants;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Categories;


namespace OnLineShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly CategoryDetailsViewModel categoryDetails;

        public CategoryController(ICategoryService categoryService, CategoryDetailsViewModel categoryDetails)
        {
            this.categoryService = categoryService;
            this.categoryDetails = categoryDetails;
        }

        // GET: Categories
        public ActionResult CategoryDetails(int id)
        {
            Category category = this.categoryService.GetById(id);

            CategoryDetailsViewModel categoryDetails = new CategoryDetailsViewModel(category);

            return View(this.categoryDetails);
        }

        [ChildActionOnly]
        public ActionResult ProductList(int id)
        {
            Category category = this.categoryService.GetById(id);

            CategoryDetailsViewModel categoryDetails = new CategoryDetailsViewModel(category);

            List<OnLineShop.Web.Models.Products.ProductsViewModel> products = categoryDetails.Products.ToList();

            return PartialView(PartialConstants.ProductsPartial, products);
        }
    }
}