using OnLineShop.Common.Constants;
using System.ComponentModel.DataAnnotations;

using OnLineShop.Data.Models;
using System.Collections.Generic;

namespace OnLineShop.Web.Models.ShoppingCart
{
    public class ContactInfoViewModel
    {

        public ContactInfoViewModel()
        {
        }

        public ContactInfoViewModel(ContactInfo contactInfo)
        {
            this.Id = contactInfo.Id;
            this.FirstName = contactInfo.FirstName;
            this.LastName = contactInfo.LastName;
            this.PhoneNumber = contactInfo.PhoneNumber;
            this.AddressLine = contactInfo.AddressLine;
            this.City = contactInfo.City;
            this.Area = contactInfo.Area;
            this.PostCode = contactInfo.PostCode;
            this.OrderDetails = new List<OrderDetailViewModel>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Име")]
        [MinLength(ValidationConstants.StandardMinLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        [MaxLength(ValidationConstants.StandartMaxLength, ErrorMessage = ValidationConstants.MaxLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinus, ErrorMessage = ValidationConstants.NotAllowedSymbolsErrorMessage)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        [MinLength(ValidationConstants.StandardMinLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        [MaxLength(ValidationConstants.StandartMaxLength, ErrorMessage = ValidationConstants.MaxLengthFieldErrorMessage)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinus)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        [RegularExpression(ValidationConstants.PhoneRegex)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Адрес")]
        [MinLength(ValidationConstants.AddressMinLength)]
        [MaxLength(ValidationConstants.AddressMaxLength)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinus)]
        public string AddressLine { get; set; }

        [Required]
        [Display(Name = "Населено място")]
        [MinLength(ValidationConstants.StandardMinLength)]
        [MaxLength(ValidationConstants.StandartMaxLength)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinus)]
        public string City { get; set; }

        [Required]
        [Display(Name = "Област")]
        [MinLength(ValidationConstants.StandardMinLength)]
        [MaxLength(ValidationConstants.StandartMaxLength)]
        [RegularExpression(ValidationConstants.EnBgSpaceMinusDot)]
        public string Area { get; set; }

        [Required]
        [Display(Name = "Пощенски код")]
        public string PostCode { get; set; }

        public IList<OrderDetailViewModel> OrderDetails { get; set; }
    }
}