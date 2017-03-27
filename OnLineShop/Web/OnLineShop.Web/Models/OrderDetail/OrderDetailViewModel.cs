using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.Sizes;

namespace OnLineShop.Web.Models.OrderDetail
{
    public class OrderDetailViewModel
    {


        public OrderDetailViewModel()
        {
        }

        public OrderDetailViewModel(ProductDetailsViewModel product, int quantity, string size)
        {
            this.Product = product;
            this.Quantity = quantity;
            this.Size = size;
        }

        public ProductDetailsViewModel Product { get; private set; }

        public int Quantity { get; private set; }

        public string Size{ get; set; }
    }
}