using System.Collections.Generic;

using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OnLineShop.Data.Models
{
    public class User : IdentityUser
    {
        private ICollection<Order> orders;
        private ICollection<ContactInfo> contactInfos;

        public User()
        {
            this.orders = new HashSet<Order>();
            this.contactInfos = new HashSet<ContactInfo>();
        }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Order> Orders
        {
            get
            {
                return this.orders;
            }

            set
            {
                this.orders = value;
            }
        }

        public virtual ICollection<ContactInfo> ContactInfos
        {
            get
            {
                return this.contactInfos;
            }

            set
            {
                this.contactInfos = value;
            }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
