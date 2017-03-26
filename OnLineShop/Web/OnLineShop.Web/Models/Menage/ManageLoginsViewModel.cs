using System.Collections.Generic;

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace OnLineShop.Web.Models.Menage
{
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }
}