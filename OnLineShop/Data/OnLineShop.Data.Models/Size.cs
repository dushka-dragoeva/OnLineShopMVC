using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Data.Models.Contracts;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Models
{
    public class Size : IDbModel
    {
        private ICollection<Product> products;

        public Size()
        {
            this.Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(1)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.EnBgDigitSpaceMinus, ErrorMessage = ValidationConstants.MaxLengthFieldErrorMessage)]
        public string Value { get; set; }

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
