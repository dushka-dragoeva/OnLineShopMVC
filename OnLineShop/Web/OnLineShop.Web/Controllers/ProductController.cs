using System.Web.Mvc;

using Bytes2you.Validation;

using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Products;
using System.Linq;
using OnLineShop.Common.Constants;

namespace OnLineShop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            Guard.WhenArgument(productService, "productService").IsNull().Throw();

            this.productService = productService;
        }

        // GET: Product
        [HttpGet]
        public ActionResult ProductDetails(int? id)
        {
            Product product = this.productService.GetById(id);

            if (product == null)
            {

                ViewBag.Message = $" Продукт с ID {id} не е намерен.";

                return View();
            }
            else
            {
                ProductDetailsViewModel productDetails = new ProductDetailsViewModel(product);

                return View(productDetails);
            }
        }

        // GET: Product
        [HttpPost]
        public ActionResult ProductDetails()
        {
            return Redirect("/");
        }

        [ChildActionOnly]
        public ActionResult LatestProducts()
        {
            var products = this.productService.GetLast12WithCategoryAndBrand().ToList();

            var latestProducts = this.productService.GetLast12WithCategoryAndBrand()
                                      .Select(p => new ProductsViewModel(p)).ToList();

            return PartialView(PartialConstants.ProductsPartial, latestProducts);
        }
    }
}