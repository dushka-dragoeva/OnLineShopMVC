using System.Collections.Generic;
using System.Linq;

using OnLineShop.Data.Models;
using System.ComponentModel.DataAnnotations;
using OnLineShop.Common.Constants;
using System.Web.Mvc;
using OnLineShop.Web.Models.Sizes;

namespace OnLineShop.Web.Models.Products
{
    [ValidateAntiForgeryToken]
    public class ProductDetailsViewModel
    {
        private const int MinOrdeQuantity = 1;

        public ProductDetailsViewModel()
        {
        }

        public ProductDetailsViewModel(Product product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.PictureUrl = product.PictureUrl;
            this.CategoryName = product.Category.Name;
            this.BrandName = product.Brand.Name;
            this.Price = product.Price;
            this.Description = product.Description;
            this.ModelNumber = product.ModelNumber;
            this.Quantity = MinOrdeQuantity;
            this.Sizes = product.Sizes.Select(s => new SizeViewModel(s)).ToList();
        }
        private ICollection<SizeViewModel> sizes = new List<SizeViewModel>();

        public int Id { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public string Description { get; set; }

        public string ModelNumber { get; set; }

        public string CategoryName { get; set; }

        public string BrandName { get; set; }

        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [Range(
            ValidationConstants.QuantityMinValue,
            ValidationConstants.QuantityMaxValue,
            ErrorMessage = ValidationConstants.QuаntityOutOfRangeErrorMessage)]
        [Display(Name = "Брой:")]
        public int Quantity { get; set; }

        public virtual IEnumerable<SizeViewModel> Sizes { get; set; }
    }
}