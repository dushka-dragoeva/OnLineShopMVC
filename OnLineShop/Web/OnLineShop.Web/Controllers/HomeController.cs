using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AutoMapper;

using OnLineShop.Data.Models;
using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.Categories;
using OnLineShop.Common.Constants;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Services.Logic.Contracts;

namespace OnLineShop.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IMappingService mappingService;

        public HomeController(IProductService productService, ICategoryService categoryService, IMappingService mappingService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.mappingService = mappingService;
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

            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductsViewModel>());

            List<ProductsViewModel> productsView = Mapper.Map<List<Product>, List<ProductsViewModel>>(products);

            return PartialView(PartialConstants.ProductsPartial, productsView);
        }

        [ChildActionOnly]
        public ActionResult CategoriesNavigation()
        {
            var categories = this.categoryService.GetAll().ToList();

            Mapper.Initialize(cfg => cfg.CreateMap<Category, CategoriesNavigationViewModel>());

            List<CategoriesNavigationViewModel> navigationCategories = Mapper.Map<List<Category>, List<CategoriesNavigationViewModel>>(categories);

            ViewBag.Categories = navigationCategories;

            return PartialView("_CategoriesPartial", navigationCategories);
        }
    }
}