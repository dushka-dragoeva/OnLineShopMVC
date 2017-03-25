using OnLineShop.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace OnLineShop.Web.Models.Products
{
    public class ProductsViewModel
    {
        public ProductsViewModel()
        {
        }

        public ProductsViewModel(Product product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.PictureUrl = product.PictureUrl;
            this.CategoryName = product.Category.Name;
            this.BrandName = product.Brand.Name;
            this.Price = product.Price;
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public string CategoryName { get; set; }

        public string BrandName { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
    }
}