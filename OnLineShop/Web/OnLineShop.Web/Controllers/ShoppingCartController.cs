using System.Collections.Generic;
using System.Web.Mvc;

using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.OrderDetail;
using Bytes2you.Validation;

namespace OnLineShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        IProductService productService;
        IList<OrderDetailViewModel> cart;

        public ShoppingCartController(IProductService productService)
        {
            Guard.WhenArgument(productService, "productService").IsNull().Throw();

            this.productService = productService;
        }

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
                this.cart = new List<OrderDetailViewModel>();
            }
            else
            {
                this.cart = (List<OrderDetailViewModel>)Session["cart"];
            }

            cart.Add(new OrderDetailViewModel(productToAdd, productQuantity, productSize));
            Session["cart"] = cart;

            ViewBag.Count = cart.Count;
            return RedirectToAction("MyCart");
        }

      
        public ActionResult Delete(int index)
        {
            this.cart = (List<OrderDetailViewModel>)Session["cart"];
            // int index = IsExisting(id);
            this.cart.RemoveAt(index);
            Session["cart"] = this.cart;

            ViewBag.Count = cart.Count;
            return RedirectToAction("MyCart");
        }
    }
}