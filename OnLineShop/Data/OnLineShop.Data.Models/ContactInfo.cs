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
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage = ValidationConstants.ShortFieldError)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage =ValidationConstants.LongFieldError)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinus, ErrorMessage =ValidationConstants.NotAllowedSymbolsError)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(ValidationConstants.NameMinLength, ErrorMessage = ValidationConstants.ShortFieldError)]
        [MaxLength(ValidationConstants.NameMaxLength, ErrorMessage = ValidationConstants.LongFieldError)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinus)]
        public string LastName { get; set; }

        //[Required]
        //[RegularExpression(ValidationConstants.EmailRegex)]
        //public string Email { get; set; }

        //[Required]
        //[RegularExpression(ValidationConstants.PhoneRegex)]
        //public string PhoneNumber { get; set; }

        public bool IsDeleted { get; set; }
    }
}
