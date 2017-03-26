using System.Collections.Generic;
using System.Web.Mvc;

namespace OnLineShop.Web.Models.Menage
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }
    }
}