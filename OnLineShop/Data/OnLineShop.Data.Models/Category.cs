using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Data.Models.Contracts;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Models
{
    public class Category : IDbModel
    {
        private ICollection<Product> products;
        private ICollection<Category> subCategories;

        public Category()
        {
            this.Products = new HashSet<Product>();
            this.SubCategories = new HashSet<Category>();
        }

        [Key]
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage = ValidationConstants.MaxLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.EnBgDigitSpaceMinus, ErrorMessage = ValidationConstants.NotAllowedSymbolsErrorMessage)]
        public string Name { get; set; }

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

        public virtual ICollection<Category> SubCategories
        {
            get
            {
                return this.subCategories;
            }

            set
            {
                this.subCategories = value;
            }
        }
    }
}
