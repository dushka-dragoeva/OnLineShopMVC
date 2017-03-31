using System.Web.Mvc;

namespace OnLineShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private const int CashDuration = 15 * 60;

       // [OutputCache(Duration = CashDuration, VaryByParam = "none")]
        public ActionResult Index()
        {
            ViewBag.Message = "Най-новиte продукти";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}