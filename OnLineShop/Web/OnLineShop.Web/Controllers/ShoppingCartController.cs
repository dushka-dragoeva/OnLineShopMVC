﻿using System.Collections.Generic;
using System.Web.Mvc;

using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.OrderDetail;
using Bytes2you.Validation;
using OnLineShop.Web.Models.ShoppingCart;

namespace OnLineShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IProductService productService;

        public ShoppingCartController(IProductService productService)
        {
            Guard.WhenArgument(productService, "productService").IsNull().Throw();

            this.productService = productService;
        }

        public List<OrderDetailViewModel> CartItems { get; set; }

        [HttpGet]
        public ActionResult MyCart()
        {
            if (Session["cart"] == null)
            {
                ViewBag.Count = 0;
                return View("EmptyCart");
            }
            else
            {
                this.CartItems = (List<OrderDetailViewModel>)Session["cart"];
                ViewBag.Count = CartItems.Count;
                return View("MyCart", Session["cart"]);
            }
        }

        [HttpPost]
        public ActionResult OrderNow(int? id)
        {
            var productToAdd = new ProductDetailsViewModel(this.productService.GetById(id));
            var productSize = this.Request.Params["Size"];
            var productQuantity = int.Parse(this.Request.Params["Quantity"]);

            if (Session["cart"] == null)
            {
                this.CartItems = new List<OrderDetailViewModel>();
            }
            else
            {
                this.CartItems = (List<OrderDetailViewModel>)Session["cart"];
            }

            CartItems.Add(new OrderDetailViewModel(productToAdd, productQuantity, productSize));
            Session["cart"] = CartItems;

            return RedirectToAction("MyCart");
        }

        public ActionResult Delete(int index)
        {
            this.CartItems = (List<OrderDetailViewModel>)Session["cart"];
            // int index = IsExisting(id);
            this.CartItems.RemoveAt(index);
            Session["cart"] = this.CartItems;

            return RedirectToAction("MyCart");
        }
    }
}