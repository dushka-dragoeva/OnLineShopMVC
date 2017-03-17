using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using OnLineShop.Data.Models.Contracts;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Models
{
    public class ContactInfo : IDbModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public string CustomerID { get; set; }

        public virtual User Customer { get; set; }

        [Required]
        [MinLength(ValidationConstants.NameMinLength)]
        [MaxLength(ValidationConstants.NameMaxLength)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinus)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(ValidationConstants.NameMinLength)]
        [MaxLength(ValidationConstants.NameMaxLength)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinus)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(ValidationConstants.EmailRegex)]
        public string Email { get; set; }

        [Required]
        [RegularExpression(ValidationConstants.PhoneRegex)]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression(ValidationConstants.DescriptionRegex)]
        [ForeignKey("Address")]
        public int AddressID { get; set; }

        public virtual Address Address { get; set; }

        //[ForeignKey("DeliveryAddress")]
        //public int DeliveryAddressID { get; set; }

        //public virtual Address DeliveryAddress { get; set; }

        public bool IsDeleted { get; set; }
    }
}
