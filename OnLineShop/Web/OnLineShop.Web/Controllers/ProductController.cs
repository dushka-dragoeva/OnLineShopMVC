using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.Sizes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnLineShop.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ProductDetailsViewModel productDetails;

        public ProductController(IProductService productService, ProductDetailsViewModel productDetails)
        {
            this.productService = productService;
            this.productDetails = productDetails;

        }

        // GET: Product
        [HttpGet]
        public ActionResult ProductDetails(int? id)
        {
            var product = this.productService.GetById(id);

            if (product == null)
            {

                return Redirect("/");
            }

            this.productDetails.Id = product.Id;
            this.productDetails.Name = product.Name;
            this.productDetails.PictureUrl = product.PictureUrl;
            this.productDetails.BrandName = product.Brand.Name;
            this.productDetails.Price = product.Price;

            foreach (var size in product.Sizes)
            {
                productDetails.Sizes.Add(new SizeViewModel
                {
                    Id = size.Id,
                    Value = size.Value
                });
            }

            this.productDetails.Description = product.Description;
            this.productDetails.ModelNumber = product.ModelNumber;

            return View(this.productDetails);
        }


        // GET: Product
        [HttpPost]
        public ActionResult ProductDetails()
        {
            return Redirect("/");
        }
    }
}