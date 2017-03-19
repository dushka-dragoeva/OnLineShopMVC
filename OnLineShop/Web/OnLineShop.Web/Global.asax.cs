﻿using OnLineShop.Web.App_Start;
using OnLineShop.Web.Infrastructure.AutoMapper;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OnLineShop.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DbConfig.Initilize();
            ViewEngineConfig.RegisterViewEngin(ViewEngines.Engines);
            AutoMapperConfig.Config(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
