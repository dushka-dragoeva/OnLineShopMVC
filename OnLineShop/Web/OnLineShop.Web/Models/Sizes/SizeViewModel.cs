using System.ComponentModel.DataAnnotations;
using OnLineShop.Common.Constants;
using OnLineShop.Data.Models;

namespace OnLineShop.Web.Models.Sizes
{
    public class SizeViewModel
    {
        public SizeViewModel()
        {
        }

        public SizeViewModel(Size size)
        {
            this.Id = size.Id;
            this.Value = size.Value;
        }
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