using OnLineShop.Data.Models;
using OnLineShop.Web.Infrastructure.AutoMapper.Contracts;
using System.ComponentModel.DataAnnotations;

namespace OnLineShop.Web.Models.Products
{
    public class ProductsViewModel :IMapFrom<Product>
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
                
        public string PictureUrl { get; set; }

        public string CategoryName { get; set; }

        public string BrandName { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
    }
}