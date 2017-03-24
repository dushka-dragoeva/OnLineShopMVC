
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Categories;
using AutoMapper;
using OnLineShop.Data.Models;
using OnLineShop.Web.Models.Products;

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

            var category = this.categoryService.GetById(id);

          
            this.categoryDetails.Id = category.Id;
            this.categoryDetails.Name = category.Name;
            this.categoryDetails.Products = new List<ProductsViewModel>();

            foreach (var product in category.Products)
            {
                this.categoryDetails.Products.Add(new ProductsViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    BrandName = product.Brand.Name,
                    PictureUrl = product.PictureUrl,
                    Price = product.Price,
                    CategoryName = category.Name

                });
            }
            return View(this.categoryDetails);
        }

    }
}