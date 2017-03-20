using AutoMapper;
using OnLineShop.Data.Models;
using OnLineShop.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.Categories;

namespace OnLineShop.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ProductService productService;
        private readonly CategoryService categoryService;

        public HomeController(ProductService productService, CategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var products = this.productService.GetAllWithCategoryBrand().ToArray();

            Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductsViewModel>());

            ProductsViewModel[] arrayDest = Mapper.Map<Product[], ProductsViewModel[]>(products);

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

        //[ChildActionOnly]
        public ActionResult CategoriesNavigatin() 
        {
            var categories = this.categoryService.GetAll().ToList();

            Mapper.Initialize(cfg => cfg.CreateMap<Category, CategoriesNavigationViewModel>());

            List<CategoriesNavigationViewModel> navigationCategories = Mapper.Map<List<Category>, List<CategoriesNavigationViewModel>>(categories);

            ViewBag.Categories = navigationCategories;

            return View("_CategoriesPartial", navigationCategories);
        }
    }
}