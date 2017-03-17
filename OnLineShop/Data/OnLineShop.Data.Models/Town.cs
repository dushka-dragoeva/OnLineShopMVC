using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OnLineShop.Data.Models.Contracts;
using OnLineShop.Common.Constants;

namespace OnLineShop.Data.Models
{
    public class Town :IDbModel
    {
        public int Id { get; set; }
        
        public bool IsDeleted { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(ValidationConstants.NameMinLength)]
        [MaxLength(ValidationConstants.NameMinLength)]
        [RegularExpression(ValidationConstants.EnBgDigitSpaceMinus)]
        public string Name { get; set; }
       
    }
}
