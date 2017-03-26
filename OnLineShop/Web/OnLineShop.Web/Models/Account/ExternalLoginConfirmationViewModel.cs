using System.ComponentModel.DataAnnotations;

namespace OnLineShop.Web.Models.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}