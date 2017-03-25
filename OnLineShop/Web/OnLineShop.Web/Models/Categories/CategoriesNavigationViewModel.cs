using System.Web.Mvc;

using OnLineShop.Data.Models;

namespace OnLineShop.Web.Models.Categories
{

    public class CategoriesNavigationViewModel
    {
        public CategoriesNavigationViewModel()
        {
        }

        public CategoriesNavigationViewModel(Category category)
        {
            if (category != null)
            {
                this.Id = category.Id;
                this.Name = category.Name;
            }
        }

        [HiddenInput]
        public int Id { get; set; }

        //[Required]
        //[MinLength(ValidationConstants.StandardMinLength, ErrorMessage = ValidationConstants.MinLengthFieldErrorMessage)]
        //[MaxLength(ValidationConstants.StandartMaxLength, ErrorMessage = ValidationConstants.MaxLengthFieldErrorMessage)]
        //[RegularExpression(ValidationConstants.EnBgDigitSpaceMinus, ErrorMessage = ValidationConstants.NotAllowedSymbolsErrorMessage)]
        public string Name { get; set; }
    }
}