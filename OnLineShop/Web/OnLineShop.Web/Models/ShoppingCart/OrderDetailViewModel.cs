using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.Sizes;

namespace OnLineShop.Web.Models.ShoppingCart
{
    public class OrderDetailViewModel
    {


        public OrderDetailViewModel()
        {
        }

        public OrderDetailViewModel(ProductDetailsViewModel product, int quantity, SizeViewModel size)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.Size = size;
        }

        public ProductDetailsViewModel Product { get; private set; }

        public int Quantity { get; private set; }

        public SizeViewModel Size { get; private set; }

    }
}