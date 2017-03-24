using System.ComponentModel.DataAnnotations;
using OnLineShop.Common.Constants;

namespace OnLineShop.Web.Models.Sizes
{
    public class SizeViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.StandardMinLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        [MaxLength(ValidationConstants.StandartMaxLength, ErrorMessage = ValidationConstants.MaxLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.EnBgDigitSpaceMinus, ErrorMessage = ValidationConstants.NotAllowedSymbolsErrorMessage)]
        [Display(Name = "Размер:")]
        public string Value { get; set; }
    }
}