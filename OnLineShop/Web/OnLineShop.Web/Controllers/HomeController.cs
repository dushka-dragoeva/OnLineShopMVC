using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AutoMapper;

using OnLineShop.Data.Models;
using OnLineShop.Data.Services;
using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.Categories;
using OnLineShop.Common.Constants;
using OnLineShop.Data.Services.Contracts;
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

        [ChildActionOnly]
        public ActionResult LatestProducts()
        {
            var products = this.productService.GetAllWithCategoryBrand().ToList();
            
            //this.mappingService.Map<List<Product>>(products);
            //List<ProductsViewModel> productsView = new List<ProductsViewModel>();
            //    this.mappingService.
            //    Map<List< Product>, List<ProductsViewModel>>(products, productsView);

             Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductsViewModel>());

             List<ProductsViewModel> productsView = Mapper.Map<List<Product>, List<ProductsViewModel>>(products);

            ViewBag.Products = productsView;

            return PartialView(PartialConstants.ProductsPartial, productsView);
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