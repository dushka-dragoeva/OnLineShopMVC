using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Common.Constants;
using OnLineShop.Data.Models.Contracts;
using System;
using System.Threading;
using System.Globalization;

namespace OnLineShop.Data.Models
{
    public class Product : IDbModel
    {
        private ICollection<Size> sizes;
        public Product()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            this.sizes = new HashSet<Size>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage = ValidationConstants.MaxLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.EnBgDigitSpaceMinus, ErrorMessage = ValidationConstants.NotAllowedSymbolsErrorMessage)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [MinLength(ValidationConstants.DescriptionMinLength, ErrorMessage = ValidationConstants.MinLengthDescriptionErrorMessage)]
        [MaxLength(ValidationConstants.DescriptionMaxLength, ErrorMessage = ValidationConstants.MaxLengthDescriptionErrorMessage)]
        [RegularExpression(ValidationConstants.DescriptionRegex, ErrorMessage = ValidationConstants.NotAllowedSymbolsErrorMessage)]
        public string Description { get; set; }

        [Required]
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage = ValidationConstants.MaxLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.DescriptionRegex, ErrorMessage = ValidationConstants.NotAllowedSymbolsErrorMessage)]
        public string ModelNumber { get; set; }

        [Required]
        [Range(
            ValidationConstants.QuantityMinValue,
            ValidationConstants.QuantityMaxValue,
            ErrorMessage = ValidationConstants.QuаntityOutOfRangeErrorMessage)]
        public int Quantity { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        //  public virtual CartItem CartItem { get; set; }

        [MinLength(ValidationConstants.ImageUrlMinLength, ErrorMessage = ValidationConstants.MinLengthUrlErrorMessage)]
        [MaxLength(ValidationConstants.ImageUrlMaxLength, ErrorMessage = ValidationConstants.MaxLengthUrlErrorMessage)]
        public string PictureUrl { get; set; }

        [Required]
        [Range(typeof(decimal),
            ValidationConstants.PriceMinValue,
            ValidationConstants.PriceMaxValue,
            ErrorMessage = ValidationConstants.PriceOutOfRangeErrorMessage)]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }

        public DateTime AddedOn { get; set; }

        public virtual ICollection<Size> Sizes
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
        public bool IsDeleted { get; set; }
    }
}
