using OnLineShop.Data;
using OnLineShop.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OnLineShop.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Database.SetInitializer<OnLineShopDbContext>(null);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OnLineShopDbContext, Configuration>());
            OnLineShopDbContext.Create().Database.Initialize(true);
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OnLineShopDbContext>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
