using OnLineShop.Common.Constants;
using OnLineShop.Data.Models;
using OnLineShop.Web.Infrastructure.AutoMapper.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OnLineShop.Web.Models.Categories
{

    public class CategoriesNavigationViewModel : IMapFrom<Category>
    {
        public CategoriesNavigationViewModel()
        {
        }

        public CategoriesNavigationViewModel( Category category)
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