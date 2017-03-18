using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Data.Models.Contracts;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Models
{
    public class Brand : IDbModel
    {
        private ICollection<Product> products;

        public Brand()
        {
            this.Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage =ValidationConstants.MinLengthFieldErrorMessage)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage =ValidationConstants.MaxLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.EnBgDigitSpaceMinus, ErrorMessage =ValidationConstants.NotAllowedSymbolsErrorMessage)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [MinLength(ValidationConstants.DescriptionMinLength)]
        [MaxLength(ValidationConstants.DescriptionMaxLength)]
        [RegularExpression(ValidationConstants.DescriptionRegex)]
        public string Description { get; set; }

        [MinLength(ValidationConstants.UrlLengthMinLength, ErrorMessage =ValidationConstants.MinLengthUrlErrorMessage)]
        [MaxLength(ValidationConstants.UrlLengthMaxValue, ErrorMessage =ValidationConstants.MaxLengthUrlErrorMessage)]

        public string ImageUrl { get; set; }

        public virtual ICollection<Product> Products
        {
            get
            {
                return this.products;
            }

            set
            {
                this.products = value;
            }
        }

        public bool IsDeleted { get; set; }

    }
}
