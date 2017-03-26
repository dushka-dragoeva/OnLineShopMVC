using System.ComponentModel.DataAnnotations;

namespace OnLineShop.Web.Models.Account
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}