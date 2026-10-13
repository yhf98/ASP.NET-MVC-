using ASP.NET_AJAX的应用.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_AJAX的应用.Controllers
{
    public class HomeController : Controller
    {
        private readonly meixinEntities _db;

        public HomeController(meixinEntities db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return View();
            }
            var result = _db.m_product.Where(p => p.pname.Contains(key)).ToList();
            return PartialView("_source", result);
        }

        public IActionResult Go()
        {

            ViewBag.Items = new string[] { "王二狗", "WANNNG", "王二狗", "WANNNG", "王二狗", "WANNNG" };

            return PartialView("_data");
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
