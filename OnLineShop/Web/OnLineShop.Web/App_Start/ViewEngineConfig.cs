using System.Web.Mvc;

namespace OnLineShop.Web.App_Start
{
    public class ViewEngineConfig
    {
        internal static void RegisterViewEngin(ViewEngineCollection viewEngineCollection)
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}