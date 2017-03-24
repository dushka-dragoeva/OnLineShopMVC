using System.Collections.Generic;

using OnLineShop.Data.Models;
using OnLineShop.Web.Infrastructure.AutoMapper.Contracts;
using System.ComponentModel.DataAnnotations;
using OnLineShop.Common.Constants;
using System.Web.Mvc;
using OnLineShop.Web.Models.Sizes;

namespace OnLineShop.Web.Models.Products
{
    [ValidateAntiForgeryToken]
    public class ProductDetailsViewModel : IMapFrom<Product>
    {
        private ICollection<SizeViewModel> sizes = new List<SizeViewModel>();

        public int Id { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public string Description { get; set; }

        public string ModelNumber { get; set; }

        public string CategoryName { get; set; }

        public string BrandName { get; set; }

        public decimal? Price { get; set; }

        //[Required(ErrorMessage ="Полето {0} е задълвително")]
        //[Range(
        //    ValidationConstants.QuantityMinValue,
        //    ValidationConstants.QuantityMaxValue,
        //    ErrorMessage = ValidationConstants.QuаntityOutOfRangeErrorMessage)]
       // [Display(Name = "Брой:")]
        public int Quantity { get; set; }

        public virtual ICollection<SizeViewModel> Sizes
        {
            get
            {
                return this.sizes;
            }
            set
            {
                this.sizes = value;
            }
        }
    }
}