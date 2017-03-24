using System.Linq;
using System.Web.Mvc;

using Bytes2you.Validation;

using OnLineShop.Common.Constants;
using OnLineShop.Services.Data.Contracts;
using OnLineShop.Web.Models.Products;
using OnLineShop.Web.Models.Categories;

namespace OnLineShop.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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