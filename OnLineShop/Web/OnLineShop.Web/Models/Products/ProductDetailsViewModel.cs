using System.Collections.Generic;

using OnLineShop.Data.Models;
using OnLineShop.Web.Infrastructure.AutoMapper.Contracts;

namespace OnLineShop.Web.Models.Products
{
    public class ProductDetailsViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public string Description { get; set; }

        public string ModelNumber { get; set; }

        public string CategoryName { get; set; }

        public string BrandName { get; set; }

        public decimal? Price { get; set; }

        public virtual ICollection<string> SizeValues { get; set; }


    }
}