using System.ComponentModel.DataAnnotations;

namespace OnLineShop.Web.Models.Menage
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}