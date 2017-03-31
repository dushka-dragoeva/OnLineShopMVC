using System.Collections.Generic;

namespace OnLineShop.Web.Models.ShoppingCart
{
    public class ShoppingCartViewModel
    {
        // private IList<OrderDetailViewModel> cartItems = new List<OrderDetailViewModel>();

        public ShoppingCartViewModel()
        {
            this.CartItems = new List<OrderDetailViewModel>();
        }

        //public ShoppingCartViewModel(IList<OrderDetailViewModel> cart)
        //{
        //    this.CartItems = new List<OrderDetailViewModel>();
        //}

        public IList<OrderDetailViewModel> CartItems { get; set; }

        //public IList<OrderDetailViewModel> CartItems
        //{
        //    get
        //    {
        //        return this.cartItems;
        //    }
        //    set
        //    {
        //        this.cartItems = value;
        //    }
        //}

        public int ProductsCount
        {
            get
            {
                return this.CartItems.Count;
            }
        }
        public decimal Total { get; set; }
    }
}