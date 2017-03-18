using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineShop.Data
{
    public interface IOnLineShopBaseDbContext
    {
        int SaveChanges();
    }
}
