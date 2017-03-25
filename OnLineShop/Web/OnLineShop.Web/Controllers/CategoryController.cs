﻿using System.Collections.Generic;
using System.Linq;

using System.Web.Mvc;

using OnLineShop.Common.Constants;
using OnLineShop.Data.Models;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Categories;
using Bytes2you.Validation;

namespace OnLineShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;


        public CategoryController(ICategoryService categoryService)
        {
            Guard.WhenArgument(categoryService, "categoryService").IsNull().Throw();
            this.categoryService = categoryService;
        }

        // GET: Categories
        public ActionResult CategoryDetails(int? id)
        {
            Category category = this.categoryService.GetById(id);

            CategoryDetailsViewModel categoryDetails = new CategoryDetailsViewModel(category);

            return View(categoryDetails);
        }

        [ChildActionOnly]
        public ActionResult CategoriesNavigation()
        {
            var cat = categoryService.GetAll().ToList();

            var navigationCategories = this.categoryService.GetAll()
                                             .Select(c => new CategoriesNavigationViewModel(c)).ToList();

            return PartialView("_CategoriesPartial", navigationCategories);
        }

        [ChildActionOnly]
        public ActionResult ProductList(int? id)
        {
            Category category = this.categoryService.GetById(id);

            CategoryDetailsViewModel categoryDetails = new CategoryDetailsViewModel(category);

            List<OnLineShop.Web.Models.Products.ProductsViewModel> products = categoryDetails.Products.ToList();

            return PartialView(PartialConstants.ProductsPartial, products);
        }

        
    }
}