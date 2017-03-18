using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OnLineShop.Data.Models.Contracts;
using OnLineShop.Common.Constants;
using System.Collections.Generic;

namespace OnLineShop.Data.Models
{
    public class Town : IDbModel
    {
        private ICollection<ContactInfo> customers;

        public Town()
        {
            this.customers = new HashSet<ContactInfo>();
        }

        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        [MaxLength(ValidationConstants.NameMinLength, ErrorMessage =ValidationConstants.MaxLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.EnBgDigitSpaceMinus)]
        public string Name { get; set; }

        public virtual ICollection<ContactInfo> Customers
        {
            get
            {
                return this.customers;
            }

            set
            {
                this.customers = value;
            }
        }
    }
}
