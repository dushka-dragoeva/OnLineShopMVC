using OnLineShop.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnLineShop.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        // GET: Categories
        public ActionResult CategoryDetails(int categoryId)
        {
            var categories = this.categoryService.GetById(categoryId);

            return View(categories);
        }

    }
}