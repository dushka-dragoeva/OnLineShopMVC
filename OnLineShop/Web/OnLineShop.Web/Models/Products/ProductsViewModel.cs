using OnLineShop.Data.Models;
using OnLineShop.Web.Infrastructure.AutoMapper.Contracts;

namespace OnLineShop.Web.Models.Products
{
    public class ProductsViewModel :IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public string CategoryName { get; set; }

        public string BrandName { get; set; }

        public decimal? Price { get; set; }
    }
}