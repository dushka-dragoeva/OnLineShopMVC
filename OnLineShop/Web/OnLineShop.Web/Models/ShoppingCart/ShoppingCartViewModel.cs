namespace OnLineShop.Web.Models.ShoppingCart
{
    public class ShoppingCartViewModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
    }
}