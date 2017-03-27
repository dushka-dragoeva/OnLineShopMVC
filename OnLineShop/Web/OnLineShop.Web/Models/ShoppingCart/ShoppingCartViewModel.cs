using OnLineShop.Web.Models.OrderDetail;
using System.Collections.Generic;

namespace OnLineShop.Web.Models.ShoppingCart
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel()
        {
        }

        public ShoppingCartViewModel(ICollection<OrderDetailViewModel> cart)
        {
            this.Cart = cart;
        }

       public ICollection<OrderDetailViewModel> Cart { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
    }
}