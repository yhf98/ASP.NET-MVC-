using Microsoft.AspNetCore.Mvc;
using 过滤器.Filter;

namespace 过滤器.Controllers
{
    public class HomeController : Controller
    {
        [Login(IsChecked = true)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string username, string pwd)
        {
            if (username == "123" && pwd == "123")
            {
                HttpContext.Session.SetString("username", "123");
                return Redirect("/Home/Index");
            }
            else
            {
                ViewBag.msg = "密码错误！";
            }
            return View();
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
