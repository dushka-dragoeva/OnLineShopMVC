using System.Linq;
using System.Web.Mvc;

using Bytes2you.Validation;

using OnLineShop.Common.Constants;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.Categories;

namespace OnLineShop.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            Guard.WhenArgument(productService, "productService").IsNull().Throw();
            Guard.WhenArgument(categoryService, "categoryService").IsNull().Throw();

            this.productService = productService;
            this.categoryService = categoryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult LatestProducts()
        {
            var products = this.productService.GetLast12WithCategoryAndBrand().ToList();

            var latestProducts = this.productService.GetLast12WithCategoryAndBrand()
                                      .Select(p => new ProductsViewModel(p)).ToList();

            return PartialView(PartialConstants.ProductsPartial, latestProducts);
        }

        [ChildActionOnly]
        public ActionResult CategoriesNavigation()
        {
            var cat = categoryService.GetAll().ToList();

            var navigationCategories = this.categoryService.GetAll()
                                             .Select(c => new CategoriesNavigationViewModel(c)).ToList();

            return PartialView("_CategoriesPartial", navigationCategories);
        }
    }
}