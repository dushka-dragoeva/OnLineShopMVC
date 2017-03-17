using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Common.Constants;
using OnLineShop.Data.Models.Contracts;

namespace OnLineShop.Data.Models
{
    public class Product : IDbModel
    {
        private ICollection<Size> sizes;
        public Product()
        {
            this.sizes = new HashSet<Size>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage = ValidationConstants.ShortFieldError)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage = ValidationConstants.LongFieldError)]
        [RegularExpression(ValidationConstants.EnBgDigitSpaceMinus, ErrorMessage = ValidationConstants.NotAllowedSymbolsError)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [MinLength(ValidationConstants.DescriptionMinLength, ErrorMessage = ValidationConstants.ShortDescriptionError)]
        [MaxLength(ValidationConstants.DescriptionMaxLength, ErrorMessage = ValidationConstants.LongDescriptionError)]
        [RegularExpression(ValidationConstants.DescriptionRegex, ErrorMessage = ValidationConstants.NotAllowedSymbolsError)]
        public string Description { get; set; }

        [Required]
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage = ValidationConstants.ShortFieldError)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage = ValidationConstants.LongFieldError)]
        [RegularExpression(ValidationConstants.DescriptionRegex, ErrorMessage = ValidationConstants.NotAllowedSymbolsError)]
        public string ModelNumber { get; set; }

        [Required]
        [Range(
            ValidationConstants.QuantityMinValue,
            ValidationConstants.QuantitiMaxValue,
            ErrorMessage = ValidationConstants.QuаntityOutOfRangeError)]
        public int Quantity { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        //  public virtual CartItem CartItem { get; set; }

        [MinLength(ValidationConstants.UrlLengthMinLength, ErrorMessage = ValidationConstants.ShortUrlError)]
        [MaxLength(ValidationConstants.UrlLengthMaxValue, ErrorMessage = ValidationConstants.LongUrlError)]
        public string PictureUrl { get; set; }

        [Required]
        [Range(typeof(decimal),
            ValidationConstants.PriceMinValue,
            ValidationConstants.PriceMaxValue,
            ErrorMessage = ValidationConstants.PriceOutOfRangeError)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}", ConvertEmptyStringToNull = true)]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }

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
