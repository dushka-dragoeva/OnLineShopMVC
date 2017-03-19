using OnLineShop.Data;
using OnLineShop.Data.Migrations;
using System.Data.Entity;

namespace OnLineShop.Web.App_Start
{
    public class DbConfig
    {
        public static void Initilize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OnLineShopDbContext, Configuration>());
            OnLineShopDbContext.Create().Database.Initialize(true);
        }
    }
}